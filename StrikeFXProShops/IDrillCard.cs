using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strike_FX_Pro_Shops
{
    interface IDrillCard
    {
        int BowlerID { get; set; }
        string ConnectionString { get; set; }
        Fraction LHoleSize { get; set; }
        Fraction LLateralPitch { get; set; }
        Fraction LForwardPitch { get; set; }
        Fraction RHoleSize { get; set; }
        Fraction RLateralPitch { get; set; }
        Fraction RForwardPitch { get; set; }
        Fraction THoleSize { get; set; }
        Fraction TOffset { get; set; }
        Fraction TLateralPitch { get; set; }
        Fraction TForwardPitch { get; set; }
        Fraction TSlugSize { get; set; }
        Fraction Bridge { get; set; }
        Fraction LSpan { get; set; }
        Fraction RSpan { get; set; }
        string ModifiedBy { get; set; }
        DateTime ModifiedDate { get; set; }

        void LoadDrillCard();
        void LoadVersions(ComboBox Destination);

        void LoadVersion(int VersionIndex);
    }
}
