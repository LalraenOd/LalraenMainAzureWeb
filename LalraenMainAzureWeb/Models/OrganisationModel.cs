using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LalraenMainAzureWeb.Models
{
    public class OrganisationModel
    {
        public string EdrpouCode { get; set; }
        public string OfficialName { get; set; }
        public string Address { get; set; }
        public string MainPerson { get; set; }
        public string Occupation { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return "EdrpouCode: " + EdrpouCode +
                "\nOfficialName" + OfficialName +
                "\nAddress" + Address +
                "\nMainPerson" + MainPerson +
                "\nOccupation" + Occupation +
                "\nStatus" + Status;
        }
    }
}