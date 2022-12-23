using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ucu.Poo.Defense
{
    //La clase publication debe tener la responsabilidad de conocer el total de dinero ya que es la clase experta en la información requerida para 
    //  tal acción, porque conoce los items publicados.
    public class Publication
    {
        public DateTime EndDate { get; set; }
        //Propiedad que indica el total de dinero
        public int Total { get; set; }

        public IReadOnlyCollection<PublicationItem> Items
        {
            get
            {
                return new ReadOnlyCollection<PublicationItem>(this.items);
            }
        }

        private IList<PublicationItem> items = new List<PublicationItem>();

        public Publication(DateTime endDate)
        {
            this.EndDate = endDate;
        }
        //Cada vez que se agrega un item, se le suma al total
        public void AddItem(PublicationItem item)
        {
            this.items.Add(item);
            this.Total += item.Price * item.Quantity;
        }

        public void RemoveItem(PublicationItem item)
        {
            this.items.Remove(item);
        }
    }
}