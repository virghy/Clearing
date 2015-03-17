using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace Sorteable
{

    public class EDMBindingListView<T> where T : System.Data.Objects.DataClasses.EntityObject
    {
        private ObjectContext context;
        public EDMBindingListView(ObjectContext context)

            : base()
        {

            this.context = context;

        }
    }
}
