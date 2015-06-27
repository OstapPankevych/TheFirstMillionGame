using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MillionaireGame.Controls.Player
{
    public partial class ProgressBar : System.Web.UI.UserControl
    {
        public void ResetPlayerStatus()
        {
            HtmlGenericControl[] list = new[] { li_1, li_2, li_3, li_4, li_5, li_6, li_7, li_8, li_9, li_10, li_11, li_12, li_13, li_14, li_15 };
            for (int i = 0; i < list.Length; i++)
            {
                list[i].Attributes.Add("class", "clearItem");
            }
        }

        public void SetPlayerStatus(byte playerLevel) // playerLevel: 1..15
        {
            HtmlGenericControl[] list = new[] { li_1, li_2, li_3, li_4, li_5, li_6, li_7, li_8, li_9, li_10, li_11, li_12, li_13, li_14, li_15 };
            for (int i = 0; i < playerLevel; i++)
            {
                list[i].Attributes.Add("class", "selectedItem");
            }
        }

        public int GetMoneyCount(byte playerLevel) // playerLevel: 1..15
        {
            int[] money = { 100, 200, 300, 500, 1000, 2000, 4000, 8000, 16000, 32000, 64000, 125000, 250000, 1000000 };
            return money[playerLevel - 1];
        }
    }
}