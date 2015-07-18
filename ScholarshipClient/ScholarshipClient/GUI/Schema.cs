using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScholarshipClient.GUI
{
    public class Schema
    {
        private String schemasName;
        public String SchemasName
        {
            get { return schemasName; }
            set
            {
                schemasName = value;
            }
        }
        private String schemasTime;
        public String SchemasTime
        {
            get { return schemasTime; }
            set
            {
                schemasTime = value;
            }
        }
        private String schemasApartment;
        public String SchemasApartment
        {
            get { return schemasApartment; }
            set
            {
                schemasApartment = value;
            }
        }

        public Schema(String name, String time, String apartment)
        {
            this.schemasName = name;
            this.schemasTime = time;
            this.schemasApartment = apartment;
        }
    }
}
