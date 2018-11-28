using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International_Trading
{
    class Country : IComparable
    {
        private string countryName;
        private double gdpGrowth, Inflation, tradeBalance;
        private int hdiRanking;
        private LinkedList<string> tradePartner;

        public Country()
        {

        }

        public Country(string countryName, double gdpGrowth, double Inflation, double tradeBalance, int hdiRanking, string[] tp)
        {
            this.countryName = countryName;
            this.gdpGrowth = gdpGrowth;
            this.Inflation = Inflation;
            this.tradeBalance = tradeBalance;
            this.hdiRanking = hdiRanking;
            tradePartner = new LinkedList<string>(tp);
        }

        public string countryNameGS
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public double gdpGrowthGS
        {
            get { return gdpGrowth; }
            set { gdpGrowth = value; }
        }

        public double InflationGS
        {
            get { return Inflation; }
            set { Inflation = value; }
        }

        public double tradeBalanceGS
        {
            get { return tradeBalance; }
            set { tradeBalance = value; }
        }

        public int hdiRankingGS
        {
            get { return hdiRanking; }
            set { hdiRanking = value; }
        }

       public LinkedList<string> tradePartnerGS
       {
            get { return tradePartner; }
            set { tradePartner = value; }
       }


        public int CompareTo(object other)
        {
            Country temp = (Country)other;
            return countryName.CompareTo(temp.countryName);
        }

    }
}
