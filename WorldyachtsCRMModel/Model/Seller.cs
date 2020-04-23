using System.Collections.Generic;

namespace WorldyachtsCRMModel.Model
{
    public class Seller
    {
        /// <summary>
        /// This class works with Seller model.
        /// </summary>
        public int SellerId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
