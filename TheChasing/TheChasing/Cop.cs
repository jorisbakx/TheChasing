using System;
using System.Collections.Generic;
using System.Text;

namespace TheChasing
{
    class Cop
    {
        public Cop()
        {

        }

		public void Catch(Thief thief)
        {
			thief.Catch();
        }

		public override string ToString()
		{
			return "I am gonna catch you";
		}
	}
}
