using OutputHelperLib;
using PluginContracts;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TokenizedText2String
{
    public class Tokens2String : Plugin
    {


        public string[] InputType { get; } = { "Tokens" };
        public string OutputType { get; } = "String";

        public Dictionary<int, string> OutputHeaderData { get; set; } = new Dictionary<int, string>() { { 0, "TokenizedText" } };
        public bool InheritHeader { get; } = false;

        #region Plugin Details and Info

        public string PluginName { get; } = "Helper: Tokens to String";
        public string PluginType { get; } = "Tokenizers/Segmenters";
        public string PluginVersion { get; } = "1.0.1";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "This plugin take the output of a tokenizer and convert it back into a string. This plugin is mostly useful for passing tokenized text to the OutputFilesTXT plugin.";
        public bool TopLevel { get; } = false;
        public string PluginTutorial { get; } = "Coming Soon";


        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }

        #endregion



        public void ChangeSettings()
        {

            MessageBox.Show("This plugin does not have any settings to change.",
                    "No Settings", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }





        public Payload RunPlugin(Payload Input)
        {


            Payload pData = new Payload();
            pData.FileID = Input.FileID;
            pData.SegmentID = Input.SegmentID;

            for (int counter = 0; counter < Input.StringArrayList.Count; counter++)
            {
                pData.StringList.Add(string.Join(" ", Input.StringArrayList[counter]));
                pData.SegmentNumber.Add(Input.SegmentNumber[counter]);
            }


            return (pData);



        }



        public void Initialize() { }


        public bool InspectSettings()
        {
            return true;
        }


        public Payload FinishUp(Payload Input)
        {
            return (Input);
        }




        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {

        }

        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            return (SettingsDict);
        }
        #endregion



    }








}



