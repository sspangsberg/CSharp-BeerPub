#region Usings...

//C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Project
using BeerPubProject.Database;

#endregion

namespace BeerPubProject.Model
{
    public class Pub
    {
        #region Class Variables

        private string name;
        private List<Beer> beers = new List<Beer>();

        //beer database access object - all communication with the beer database table happens with this object
        BeerDAO beerDAO = new BeerDAO();

        #endregion

        #region Class Constructors

        public Pub(string name)
        {
            this.name = name;
            beers = beerDAO.RetrieveBeersFromDB(); //Load beers from the database (beers table)
        }

        #endregion

        #region Class Methods

        public void Add(Beer b)
        {
            beers.Add(b); //add beer to cached list

            beerDAO.CreateBeerInDB(b); //add beer to database table
        }

        public void Remove(Beer b)
        {
            beers.Remove(b); //remove beer in cached list

            beerDAO.DeleteBeerInDB(b.Name); //remove beer in database table
        }

        public void Update(Beer b)
        {
            beerDAO.UpdateBeerInDB(b);
            beers = beerDAO.RetrieveBeersFromDB(); //update cached list
        }

        public int BeerWithVolume(int v1, int v2)
        {
            int numberOfBeers = 0;

            foreach (Beer b in beers)
            {
                if (b.GetVolume() <= v2 && b.GetVolume() >= v1)
                    numberOfBeers++;
            }

            return numberOfBeers;
        }
        
        public Beer BestBuy()
        {
            Beer bestBuy = null;

            for (int i = 0; i < beers.Count; i++)
            {
                if (i + 1 < beers.Count)
                {
                    if (beers[i].GetVolumeVsPrice() > beers[i + 1].GetVolumeVsPrice())
                        bestBuy = beers[i];
                    else
                        bestBuy = beers[i + 1];
                }
            }
            return bestBuy;
        }

        public Beer FindCheapestBeer()
        {
            //first beer in list is the cheapest so far - lets see if any beer is cheaper...
            Beer cheapestSoFar = beers[0];

            for (int i = 1; i < beers.Count; i++)
            {
                if (cheapestSoFar.Price > beers[i].Price) //next beer in list is cheaper
                    cheapestSoFar = beers[i]; //overwrite cheapestSoFar variable with this beer
            }

            return cheapestSoFar;
        }

        #endregion

        #region Class Properties

        public string PubName
        {
            get { return name; }
            set { name = value; }
        }

        public List<Beer> GetBeers
        {
            get { return beers; }
        }

        #endregion
    }
}
