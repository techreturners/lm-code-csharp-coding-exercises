using System;

namespace Exercises
{
    public class Exercise003
    {
        private string[] _flavours = new string[] { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        public string[] IceCreamFlavours()
        {
            return _flavours;
        }

        public int IceCreamCode(string iceCreamFlavour)
        {
            int _ice_code = 0;

            foreach (string var in _flavours)
            {
                if (var == iceCreamFlavour)
                {
                    return _ice_code;
                }

                _ice_code++;
            }

            return -1;
        }
    }
}

