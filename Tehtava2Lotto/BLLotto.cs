using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2Lotto
{
    class Lotto
    {
        public string lotteryType;
        private int minNumber;
        private int maxNumber;
        private int lkmNumber;

        public Lotto (string lotteryType)
        {
            switch (lotteryType)
            {
                case "Suomi":
                    lotteryType = "Suomi";
                    minNumber = 1;
                    maxNumber = 39;
                    lkmNumber = 7;
                    break;
                case "VikingLotto":
                    lotteryType = "VikingLotto";
                    minNumber = 1;
                    maxNumber = 48;
                    lkmNumber = 6;
                    break;
                case "Eurojackpot":
                    lotteryType = "Eurojackpot";
                    minNumber = 1;
                    maxNumber = 50;
                    lkmNumber = 5;
                    break;
                default:
                    lotteryType = "error";
                    minNumber = 0;
                    maxNumber = 0;
                    lkmNumber = 0;
                    break;
            }
        }
        public Lotto ()
        {
            lotteryType = "error";
            minNumber = 0;
            maxNumber = 0;
            lkmNumber = 0;
        }

        public IList ArvoRivi()
        {
            return;
        } 
    }
}
