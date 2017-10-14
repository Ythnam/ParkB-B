using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkB_B.Model
{
    class Model
    {
        private List<Company> _companies;

        public Model() { }

        public Model(List<Company> comp)
        {
            this.Companies = comp;
        }

        public void AddCompany(Company comp)
        {
            this.Companies.Add(comp);
        }

        public List<Company> Companies
        {
            get { return _companies; }
            set
            {
                if (this._companies != value)
                    this._companies = value;
            }
        }
    }
}
