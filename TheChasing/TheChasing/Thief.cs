using System;
using System.Collections.Generic;
using System.Text;

namespace TheChasing
{
    class Thief
    {
		private bool isFree;

        private string name;

        public Thief( string name )
        {
			// wijs de naam toe aan het veld
			this.name = name;
			this.isFree = true;
        }

		public void Catch()
		{
			this.isFree = false;	
		}

        public override string ToString()
		{
			if (this.isFree)
			{
				return "I am free";
			}
			else
			{
				return "I am caught";
			}
		}
	}
}
