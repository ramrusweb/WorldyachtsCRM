using System.Collections.Generic;

namespace WorldyachtsCRMModel.Model
{
    public class Customer
    {
        /// <summary>
        /// This class works with the Customer model.
        /// </summary>
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
