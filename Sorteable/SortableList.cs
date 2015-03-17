using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Collections;


namespace Sorteable
{

    public class SortableList<T> : BindingList<T>, IBindingListView where T : System.Data.Objects.DataClasses.EntityObject
    {

        private ObjectContext context;

        /// <summary>
        /// Constructor that takes an ObejctContext as an argument
        /// </summary>
        /// <param name="context">The current ObejctContext being used to interact with the persistent entities</param>
        public SortableList(ObjectContext context)

            : base()
        {

            this.context = context;

        }
        /// <summary>
        /// Remove an item from the list, if the item is already attached to
        /// the object context call DeleteObject so that when we save the context
        /// this object is deleted from the store, if it is in the Detached state 
        /// just remove it from the list.
        /// </summary>
        /// <param name="index"></param>
        protected override void RemoveItem(int index)
        {



            EntityObject itemToRemove = this.Items[index];

            if (itemToRemove.EntityState != EntityState.Detached)
            {

                context.DeleteObject(itemToRemove);

            }

            base.RemoveItem(index);

        }
        /// <summary>
        /// A save changes method that allows one
        /// to save the changes in the list to the underlying 
        /// store. 
        /// The assumption is that entities that have been retrieved
        /// from the store were retrieved in a mode that stores them
        /// in the state manager and that they are being change-tracked.
        /// As a result, all we need to do is add any detached entities (new rows)
        /// to the context and then invoke save changes.        
        /// </summary>
        public void SaveChanges(string EntityName)
        {
            //EntityObject entity;
            foreach (EntityObject entity in this.Items)
            {

                if (EntityState.Detached == entity.EntityState)
                {

                    context.AddObject(EntityName, entity);

                }



            }

            context.SaveChanges();

        }

        //
        // Resumen:
        //     Gets or sets a value indicating whether adding or removing items within the
        //     list raises System.ComponentModel.BindingList<T>.ListChanged events.
        //
        // Devuelve:
        //     true if adding or removing items raises System.ComponentModel.BindingList<T>.ListChanged
        //     events; otherwise, false. The default is true.
        public bool RaiseListChangedEvents { get; set; }

        private List<T> originalListValue = new List<T>();
        public List<T> OriginalList
        {
            get
            { return originalListValue; }
        }


        /// <summary>
        /// Helper method for loading a binding list from an IEnumerable<T>
        /// T for this class is constrained to be an Entity or specialization        
        /// </summary>
        /// <param name="entities">The entities we want loaded into the binding liste</param>
        public void Load(IEnumerable<T> entities)
        {
            ResetList();
            foreach (T entity in entities)
            {

                this.Add(entity);

            }

        }


        PropertyComparerCollection<T> sorts;

        protected override bool IsSortedCore
        {
            get { return sorts != null; }
        }

        protected override void RemoveSortCore()
        {
            sorts = null;
        }


        protected override bool SupportsSortingCore
        {
            get { return true; }
        }
        protected override bool SupportsSearchingCore
        {
            get { return true; }
        }


        protected override ListSortDirection SortDirectionCore
        {
            get
            {
                return sorts == null
                    ? ListSortDirection.Ascending
                    : sorts.PrimaryDirection;
            }
        }

        protected override PropertyDescriptor SortPropertyCore
        {
            get
            {
                return sorts == null
                    ? null
                    : sorts.PrimaryProperty;
            }
        }

        protected override void ApplySortCore(PropertyDescriptor prop,
            ListSortDirection direction)
        {
            ListSortDescription[] arr = {
        new ListSortDescription(prop, direction)};
            ApplySort(new ListSortDescriptionCollection(arr));
        }

        public void ApplySort(ListSortDescriptionCollection sortCollection)
        {
            bool oldRaise = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            try
            {
                PropertyComparerCollection<T> tmp =
                    new PropertyComparerCollection<T>(sortCollection);

                List<T> items = new List<T>(this);

                items.Sort(tmp);

                int index = 0;
                foreach (T item in items)
                {
                    SetItem(index++, item);
                }
                sorts = tmp;
            }
            finally
            {
                RaiseListChangedEvents = oldRaise;
                ResetBindings();
            }
        }

        //string IBindingListView.Filter
        //{
        //    get { throw new NotImplementedException(); }
        //    set { throw new NotImplementedException(); }
        //}

        //void IBindingListView.RemoveFilter()
        //{
        //    throw new NotImplementedException();
        //}

        ListSortDescriptionCollection IBindingListView.SortDescriptions
        {
            get { return sorts.Sorts; }
        }

        bool IBindingListView.SupportsAdvancedSorting
        {
            get { return true; }
        }

        bool IBindingListView.SupportsFiltering
        {
            get { return true; }
        }

        //Para permitir Busqueda
        protected override int FindCore(PropertyDescriptor prop, object key)
        {
            foreach (T item in this)
            {
                if (!(prop.GetValue(item) == null))
                {
                    if (prop.GetValue(item).GetType() == typeof(decimal) | prop.GetValue(item).GetType() == typeof( Nullable<decimal>))
                    {
                        if (CompararDec(Convert.ToDecimal(prop.GetValue(item)), Convert.ToDecimal(key)))
                        {
                            return this.IndexOf(item);
                        }

                    }

                    else if (prop.GetValue(item).ToString().Equals(key.ToString()))
                    {
                        return this.IndexOf(item);
                    }

                }
            }

            return -1;
        }

        protected Boolean CompararDec(decimal valor, decimal key)
        {
            return valor.Equals(key);

        }

        //Para poder filtrar
        #region Filtering

        public bool SupportsFiltering
        {
            get { return true; }
        }

        public void RemoveFilter()
        {
            if (Filter != null) Filter = null;

        }

        private string filterValue = null;


        public string Filter 
        {
            get
            {
                return filterValue;
            }
            set
            {
                if (filterValue == value) return;

                // If the value is not null or empty, but doesn't
                // match expected format, throw an exception.
                if (!string.IsNullOrEmpty(value) &&
                    !Regex.IsMatch(value,
                    BuildRegExForFilterFormat(), RegexOptions.Singleline))
                    throw new ArgumentException("Filter is not in " +
                          "the format: propName[<>=]'value'.");

                //Turn off list-changed events.
                RaiseListChangedEvents = false;

                // If the value is null or empty, reset list.
                if (string.IsNullOrEmpty(value))
                    ResetList();
                else
                {
                    int count = 0;
                    string[] matches = value.Split(new string[] { " AND " },
                        StringSplitOptions.RemoveEmptyEntries);

                    while (count < matches.Length)
                    {
                        string filterPart = matches[count].ToString();

                        // Check to see if the filter was set previously.
                        // Also, check if current filter is a subset of 
                        // the previous filter.
                        if (!String.IsNullOrEmpty(filterValue)
                                && !value.Contains(filterValue))
                            ResetList();

                        // Parse and apply the filter.
                        SingleFilterInfo filterInfo = ParseFilter(filterPart);
                        ApplyFilter(filterInfo);
                        count++;
                    }
                }
                // Set the filter value and turn on list changed events.
                filterValue = value;
                RaiseListChangedEvents = true;
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
        }


        // Build a regular expression to determine if 
        // filter is in correct format.
        public static string BuildRegExForFilterFormat()
        {
            StringBuilder regex = new StringBuilder();

            // Look for optional literal brackets, 
            // followed by word characters or space.
            regex.Append(@"\[?[\w\s]+\]?\s?");

            // Add the operators: > < or =.
            regex.Append(@"[><=]");

            //Add optional space followed by optional quote and
            // any character followed by the optional quote.
            regex.Append(@"\s?'?.+'?");

            return regex.ToString();
        }

        private void ResetList()
        {
            this.ClearItems();
            foreach (T t in originalListValue)
                this.Items.Add(t);
            if (IsSortedCore)
                ApplySortCore(SortPropertyCore, SortDirectionCore);
        }


        protected override void OnListChanged(ListChangedEventArgs e)
        {
            // If the list is reset, check for a filter. If a filter 
            // is applied don't allow items to be added to the list.
            if (e.ListChangedType == ListChangedType.Reset)
            {
                if (Filter == null || Filter == "")
                    AllowNew = true;
                else
                    AllowNew = false;
            }
            // Add the new item to the original list.
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                OriginalList.Add(this[e.NewIndex]);
                if (!String.IsNullOrEmpty(Filter))
                //if (Filter == null || Filter == "")
                {
                    string cachedFilter = this.Filter;
                    this.Filter = "";
                    this.Filter = cachedFilter;
                }
            }
            // Remove the new item from the original list.
            if (e.ListChangedType == ListChangedType.ItemDeleted)
                OriginalList.RemoveAt(e.NewIndex);

            base.OnListChanged(e);
        }


        internal void ApplyFilter(SingleFilterInfo filterParts)
        {
            List<T> results;

            // Check to see if the property type we are filtering by implements
            // the IComparable interface.
            Type interfaceType =
                TypeDescriptor.GetProperties(typeof(T))[filterParts.PropName]
                .PropertyType.GetInterface("IComparable");

            if (interfaceType == null)
                throw new InvalidOperationException("Filtered property" +
                " must implement IComparable.");

            results = new List<T>();

            // Check each value and add to the results list.
            foreach (T item in this)
            {
                if (filterParts.PropDesc.GetValue(item) != null)
                {
                    IComparable compareValue =
                        filterParts.PropDesc.GetValue(item) as IComparable;
                    int result =
                        compareValue.CompareTo(filterParts.CompareValue);
                    if (filterParts.OperatorValue ==
                        FilterOperator.EqualTo && result == 0)
                        results.Add(item);
                    if (filterParts.OperatorValue ==
                        FilterOperator.GreaterThan && result > 0)
                        results.Add(item);
                    if (filterParts.OperatorValue ==
                        FilterOperator.LessThan && result < 0)
                        results.Add(item);
                }
            }
            this.ClearItems();
            foreach (T itemFound in results)
                this.Add(itemFound);
        }

        internal SingleFilterInfo ParseFilter(string filterPart)
        {
            SingleFilterInfo filterInfo = new SingleFilterInfo();
            filterInfo.OperatorValue = DetermineFilterOperator(filterPart);

            string[] filterStringParts =
                filterPart.Split(new char[] { (char)filterInfo.OperatorValue });

            filterInfo.PropName =
                filterStringParts[0].Replace("[", "").
                Replace("]", "").Replace(" AND ", "").Trim();

            // Get the property descriptor for the filter property name.
            PropertyDescriptor filterPropDesc =
                TypeDescriptor.GetProperties(typeof(T))[filterInfo.PropName];

            // Convert the filter compare value to the property type.
            if (filterPropDesc == null)
                throw new InvalidOperationException("Specified property to " +
                    "filter " + filterInfo.PropName +
                    " on does not exist on type: " + typeof(T).Name);

            filterInfo.PropDesc = filterPropDesc;

            string comparePartNoQuotes = StripOffQuotes(filterStringParts[1]);
            try
            {
                TypeConverter converter =
                    TypeDescriptor.GetConverter(filterPropDesc.PropertyType);
                filterInfo.CompareValue =
                    converter.ConvertFromString(comparePartNoQuotes);
            }
            catch (NotSupportedException)
            {
                throw new InvalidOperationException("Specified filter" +
                    "value " + comparePartNoQuotes + " can not be converted" +
                    "from string. Implement a type converter for " +
                    filterPropDesc.PropertyType.ToString());
            }
            return filterInfo;
        }

        internal FilterOperator DetermineFilterOperator(string filterPart)
        {
            // Determine the filter's operator.
            if (Regex.IsMatch(filterPart, "[^>^<]="))
                return FilterOperator.EqualTo;
            else if (Regex.IsMatch(filterPart, "<[^>^=]"))
                return FilterOperator.LessThan;
            else if (Regex.IsMatch(filterPart, "[^<]>[^=]"))
                return FilterOperator.GreaterThan;
            else
                return FilterOperator.None;
        }

        internal static string StripOffQuotes(string filterPart)
        {
            // Strip off quotes in compare value if they are present.
            if (Regex.IsMatch(filterPart, "'.+'"))
            {
                int quote = filterPart.IndexOf('\'');
                filterPart = filterPart.Remove(quote, 1);
                quote = filterPart.LastIndexOf('\'');
                filterPart = filterPart.Remove(quote, 1);
                filterPart = filterPart.Trim();
            }
            return filterPart;
        }

        #endregion Filtering
    }
    //public struct SingleFilterInfo
    //{
    //    internal string PropName;
    //    internal PropertyDescriptor PropDesc;
    //    internal Object CompareValue;
    //    internal FilterOperator OperatorValue;
    //}

    //// Enum to hold filter operators. The chars 
    //// are converted to their integer values.
    //public enum FilterOperator
    //{
    //    EqualTo = '=',
    //    LessThan = '<',
    //    GreaterThan = '>',
    //    None = ' '
    //}

    public class PropertyComparerCollection<T> : IComparer<T>
    {
        private readonly ListSortDescriptionCollection sorts;
        private readonly PropertyComparer<T>[] comparers;

        public ListSortDescriptionCollection Sorts
        {
            get { return sorts; }
        }

        public PropertyComparerCollection(ListSortDescriptionCollection sorts)
        {
            if (sorts == null) throw new ArgumentNullException("sorts");
            this.sorts = sorts;
            List<PropertyComparer<T>> list = new List<PropertyComparer<T>>();

            foreach (ListSortDescription item in sorts)
            {
                list.Add(new PropertyComparer<T>(item.PropertyDescriptor,
                    item.SortDirection == ListSortDirection.Descending));
            }

            comparers = list.ToArray();
        }

        public PropertyDescriptor PrimaryProperty
        {
            get
            {
                return comparers.Length == 0
                    ? null
                    : comparers[0].Property;
            }
        }
        public ListSortDirection PrimaryDirection
        {
            get
            {
                return comparers.Length == 0
                    ? ListSortDirection.Ascending
                    : comparers[0].Descending
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;
            }
        }

        int IComparer<T>.Compare(T x, T y)
        {
            int result = 0;
            for (int i = 0; i < comparers.Length; i++)
            {
                result = comparers[i].Compare(x, y);
                if (result != 0) break;
            }
            return result;
        }

    }

    public class PropertyComparer<T> : IComparer<T>
    {
        private readonly bool descending;
        public bool Descending
        {
            get { return descending; }
        }

        private readonly PropertyDescriptor property;
        public PropertyDescriptor Property
        {
            get { return property; }
        }

        public PropertyComparer(PropertyDescriptor property, bool descending)
        {
            if (property == null)
            {
                throw new ArgumentNullException("property");
            }

            this.descending = descending;
            this.property = property;
        }

        public int Compare(T x, T y)
        {
            // todo; some null cases
            int value = System.Collections.Comparer.Default.Compare(
                property.GetValue(x), property.GetValue(y));

            return descending ? -value : value;
        }


   



    }
}
