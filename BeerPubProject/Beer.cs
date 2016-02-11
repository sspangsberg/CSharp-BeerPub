#region Usings...

//C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace BeerPubProject.Model
{
    public class Beer : IComparable
    {
        #region Class Variables

        private string name;
        private int volume;
        private int price;        

        #endregion

        #region Constructors

        public Beer(string name, int volume, int price)
        {
            this.name = name;
            this.volume = volume;
            this.price = price;        
        }

        public Beer()
        {
        }

        #endregion

        #region Class Methods

        public int GetVolume()
        {
            return volume;
        }

        public int GetPrice()
        {
            return price;
        }

              

        public double GetVolumeVsPrice()
        {
            return (double)volume / (double)price;
        }


        // This method should return a sensible string, describing the beer object
        public override string ToString()
        {
            return name + " (" + volume + " cl) - " + price + " kr.";
        }


        public int CompareTo(object other)
        {
            if (other is Beer)
            {
                Beer b = other as Beer;

                return this.price.CompareTo(b.price);

            }
            else
                throw new ArgumentException("Object is not a Beer");

        }

        #endregion

        #region Class Properties

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }     



        #endregion
    }
}
