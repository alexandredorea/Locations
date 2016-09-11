using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLocationJSONReader
{
    public partial class Form1 : Form
    {
        List<Country> Countries;
        List<State> States;
        List<City> Cities;

        int CountryCount = 0;
        int StateCount = 0;
        int CityCount = 0;

        List<string> FormattedLines = new List<string>();

        public Form1()
        {
            InitializeComponent();

            Countries = new List<Country>();
            States = new List<State>();
            Cities = new List<City>();
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Readbtn_Click(object sender, EventArgs e)
        {
            foreach (string Line in JSONrtxt.Lines)
            {
                FormattedLines.Add(ReturnFormattedLine(Line));
            }
            FormatWorker.RunWorkerAsync();
        }

        public string ReturnFormattedLine(string Line)
        {
            string CountryName = Between(Line, "country", "state", false, false);
            string StateName = Between(Line, "state", "city", false, false);
            string CityName = Between(Line, "city", "}", false, false);

            return "<country>"+CountryName+ "</country>, <state>" + StateName+ "</state>, <city>" + CityName+ "</city>";
        }

        public Country GetCountry(string Line)
        {
            CountryCount++;

            string CountryName = Between(Line, "country", "state", false, false);

            Country country = new Country();
            country.ID = CountryCount;
            country.Name = CountryName;

            return country;
        }

        public State GetState(string Line, int CountryID)
        {
            StateCount++;

            string StateName = Between(Line, "state", "city", false, false);

            State state = new State();
            state.ID = StateCount;
            state.Name = StateName;
            state.CountryID = CountryID;

            return state;
        }
        public City GetCity(string Line, int StateID)
        {
            CityCount++;

            string CityName = Between(Line, "city", "}", false, false);

            City city = new City();
            city.ID = CityCount;
            city.Name = CityName;
            city.StateID = StateID;

            return city;
        }

        public string Between(string strSource, string strBegin, string strEnd, bool includeBegin, bool includeEnd)
        {
            string[] result = { string.Empty, string.Empty };
            int iIndexOfBegin = strSource.IndexOf(strBegin);

            if (iIndexOfBegin != -1)
            {
                // include the Begin string if desired 
                if (includeBegin)
                    iIndexOfBegin -= strBegin.Length;

                strSource = strSource.Substring(iIndexOfBegin + strBegin.Length);

                int iEnd = strSource.IndexOf(strEnd);
                if (iEnd != -1)
                {
                    // include the End string if desired 
                    if (includeEnd)
                        iEnd += strEnd.Length;
                    result[0] = strSource.Substring(0, iEnd);
                    // advance beyond this segment 
                    if (iEnd + strEnd.Length < strSource.Length)
                        result[1] = strSource.Substring(iEnd + strEnd.Length);
                }
            }
            else
                // stay where we are 
                result[1] = strSource;
            return result[0];
        }

        private void FormatWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //once this end
            JSONrtxt.Text = "";

            foreach (string Line in FormattedLines)
            {
                JSONrtxt.AppendText(Line + "\n");
            }
        }
    }
}