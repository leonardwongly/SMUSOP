using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SMUSOP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RetrieveData();

            }

        }


        public void RetrieveData()
        {
            WebClient webClient = new WebClient();
            string myJSON = webClient.DownloadString("https://dweet.io/get/dweets/for/SMUSOP");

            dynamic jsonObj = JsonConvert.DeserializeObject(myJSON);
            for (int i = 0; i < jsonObj["with"].Count; i++)
            {
                //1st pin
                string object1 = jsonObj["with"][0]["content"]["object1"].ToString();
                string objectThreshold1 = jsonObj["with"][0]["content"]["objectThreshold1"].ToString();

                string people1 = jsonObj["with"][0]["content"]["people1"].ToString();
                string peopleThreshold1 = jsonObj["with"][0]["content"]["peopleThreshold1"].ToString();

                if (Convert.ToDouble(people1) > Convert.ToDouble(peopleThreshold1)) {
                    //People occupied
                    pin1.BackColor = Color.Red;
                    pin1.ForeColor = Color.White;
                }
                else if (Convert.ToDouble(object1) > Convert.ToDouble(objectThreshold1))
                {
                    //Object Occupied
                    pin1.BackColor = Color.Orange;
                }
                else
                {
                    //Available
                    pin1.BackColor = Color.LightGreen;
                }

                //2nd pin
                string object2 = jsonObj["with"][0]["content"]["object2"].ToString();
                string objectThreshold2 = jsonObj["with"][0]["content"]["objectThreshold2"].ToString();

                string people2 = jsonObj["with"][0]["content"]["people2"].ToString();
                string peopleThreshold2 = jsonObj["with"][0]["content"]["peopleThreshold2"].ToString();

                if (Convert.ToDouble(people2) > Convert.ToDouble(peopleThreshold2))
                {
                    //People occupied
                    pin2.BackColor = System.Drawing.Color.Red;
                }
                else if (Convert.ToDouble(object2) > Convert.ToDouble(objectThreshold2))
                {
                    //Object Occupied
                    pin2.BackColor = System.Drawing.Color.Orange;
                }
                else
                {
                    //Available
                    pin2.BackColor = System.Drawing.Color.LightGreen;
                }

                //3rd pin
                string object3 = jsonObj["with"][0]["content"]["object3"].ToString();
                string objectThreshold3 = jsonObj["with"][0]["content"]["objectThreshold3"].ToString();

                string people3 = jsonObj["with"][0]["content"]["people3"].ToString();
                string peopleThreshold3 = jsonObj["with"][0]["content"]["peopleThreshold3"].ToString();

                if (Convert.ToDouble(people3) > Convert.ToDouble(peopleThreshold3))
                {
                    //People occupied
                    pin3.BackColor = System.Drawing.Color.Red;
                }
                else if (Convert.ToDouble(object3) > Convert.ToDouble(objectThreshold3))
                {
                    //Object Occupied
                    pin3.BackColor = System.Drawing.Color.Orange;
                }
                else
                {
                    //Available
                    pin3.BackColor = System.Drawing.Color.LightGreen;
                }


            }
        }

    }


}