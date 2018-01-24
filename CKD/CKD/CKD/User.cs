using System;
using System.Collections.Generic;
using System.Text;

namespace CKD
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        public string ActivityLevel { get; set; }
        public string Uid { get; set; }
        // at some point, we need to add this.
        // We need to figure out how to get people to select their facilities.
        // public string FacilityID { get; set; }
    }
}
