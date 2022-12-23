using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount : IPublicationItem
    {
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                if (value >= 0)
                {
                    throw new ArgumentException("El descuento debe ser negativo");
                }
                this.amount = value;
            }
        }

        public PublicationDiscount(int amount)
        {
            this.SubTotal = amount;
        }
    }
}