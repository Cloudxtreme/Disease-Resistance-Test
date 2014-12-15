using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factoid_Test
{
    public partial class FactoidFrm : Form
    {
        Dictionary<string, string> rs8177374_TT_pos = null;

        const int RESULT_PROB_TRUE = 2;
        const int RESULT_TRUE = 1;
        const int RESULT_FALSE = 0;
        const int RESULT_NA = -1;

        public FactoidFrm()
        {
            InitializeComponent();
        }

        private void FactoidFrm_Load(object sender, EventArgs e)
        {
            rs8177374_TT_pos = new Dictionary<string, string>();
            rs8177374_TT_pos.Add("rs11512640", "G");
            rs8177374_TT_pos.Add("rs1941560", "C");
            rs8177374_TT_pos.Add("rs7945490", "C");
            rs8177374_TT_pos.Add("rs550276", "A");
            rs8177374_TT_pos.Add("rs575206", "G");
            rs8177374_TT_pos.Add("rs2155388", "G");
            rs8177374_TT_pos.Add("rs11220135", "A");
            rs8177374_TT_pos.Add("rs4627097", "A");
            rs8177374_TT_pos.Add("rs548181", "G");
            rs8177374_TT_pos.Add("rs503288", "G");
            rs8177374_TT_pos.Add("rs10893404", "T");
            rs8177374_TT_pos.Add("rs3740901", "A");
            rs8177374_TT_pos.Add("rs12276635", "C");
            rs8177374_TT_pos.Add("rs477961", "TC");
            rs8177374_TT_pos.Add("rs2241502", "G");
            rs8177374_TT_pos.Add("rs2241501", "C");
            rs8177374_TT_pos.Add("rs11220153", "G");
            rs8177374_TT_pos.Add("rs11220155", "G");
            rs8177374_TT_pos.Add("rs11220159", "G");
            rs8177374_TT_pos.Add("rs12276729", "A");
            rs8177374_TT_pos.Add("rs17140116", "C");
            rs8177374_TT_pos.Add("rs540723", "G");
            rs8177374_TT_pos.Add("rs525186", "A");
            rs8177374_TT_pos.Add("rs11220164", "C");
            rs8177374_TT_pos.Add("rs485231", "GA");
            rs8177374_TT_pos.Add("rs2298483", "C");
            rs8177374_TT_pos.Add("rs558351", "TC");
            rs8177374_TT_pos.Add("rs555752", "G");
            rs8177374_TT_pos.Add("rs491528", "G");
            rs8177374_TT_pos.Add("rs9943504", "G");
            rs8177374_TT_pos.Add("rs3731422", "T");
            rs8177374_TT_pos.Add("rs521102", "AG");
            rs8177374_TT_pos.Add("rs3731459", "C");
            rs8177374_TT_pos.Add("rs506504", "G");
            rs8177374_TT_pos.Add("rs474804", "A");
            rs8177374_TT_pos.Add("rs10893412", "A");
            rs8177374_TT_pos.Add("rs11220179", "A");
            rs8177374_TT_pos.Add("rs2282535", "A");
            rs8177374_TT_pos.Add("rs479195", "TC");
            rs8177374_TT_pos.Add("rs17141381", "T");
            rs8177374_TT_pos.Add("rs555144", "C");
            rs8177374_TT_pos.Add("rs11220183", "A");
            rs8177374_TT_pos.Add("rs11220184", "G");
            rs8177374_TT_pos.Add("rs7106795", "G");
            rs8177374_TT_pos.Add("rs7940606", "A");
            rs8177374_TT_pos.Add("rs4056123", "GA");
            rs8177374_TT_pos.Add("rs479932", "G");
            rs8177374_TT_pos.Add("rs11220186", "G");
            rs8177374_TT_pos.Add("rs551711", "T");
            rs8177374_TT_pos.Add("rs526941", "C");
            rs8177374_TT_pos.Add("rs519413", "G");
            rs8177374_TT_pos.Add("rs4325320", "G");
            rs8177374_TT_pos.Add("rs523563", "TC");
            rs8177374_TT_pos.Add("rs7924417", "AC");
            rs8177374_TT_pos.Add("rs12221488", "G");
            rs8177374_TT_pos.Add("rs549159", "TC");
            rs8177374_TT_pos.Add("rs12575533", "T");
            rs8177374_TT_pos.Add("rs564450", "G");
            rs8177374_TT_pos.Add("rs2217034", "T");
            rs8177374_TT_pos.Add("rs489063", "T");
            rs8177374_TT_pos.Add("rs1425840", "C");
            rs8177374_TT_pos.Add("rs11220207", "G");
            rs8177374_TT_pos.Add("rs496459", "A");
            rs8177374_TT_pos.Add("rs2114084", "A");
            rs8177374_TT_pos.Add("rs12286611", "C");
            rs8177374_TT_pos.Add("rs542285", "C");
            rs8177374_TT_pos.Add("rs541350", "T");
            rs8177374_TT_pos.Add("rs2282539", "G");
            rs8177374_TT_pos.Add("rs10790747", "C");
            rs8177374_TT_pos.Add("rs1054997", "G");
            rs8177374_TT_pos.Add("rs568195", "A");
            rs8177374_TT_pos.Add("rs1056417", "G");
            rs8177374_TT_pos.Add("rs7123340", "C");
            rs8177374_TT_pos.Add("rs12271647", "C");
            rs8177374_TT_pos.Add("rs529428", "T");
            rs8177374_TT_pos.Add("rs488340", "C");
            rs8177374_TT_pos.Add("rs4937030", "T");
            rs8177374_TT_pos.Add("rs553770", "C");
            rs8177374_TT_pos.Add("rs573327", "AG");
            rs8177374_TT_pos.Add("rs12287044", "C");
            rs8177374_TT_pos.Add("rs527195", "GA");
            rs8177374_TT_pos.Add("rs4937035", "AG");
            rs8177374_TT_pos.Add("rs484670", "A");
            rs8177374_TT_pos.Add("rs1365081", "C");
            rs8177374_TT_pos.Add("rs517463", "T");
            rs8177374_TT_pos.Add("rs552646", "G");
            rs8177374_TT_pos.Add("rs536968", "G");
            rs8177374_TT_pos.Add("rs2140230", "AG");
            rs8177374_TT_pos.Add("rs1403339", "T");
            rs8177374_TT_pos.Add("rs1522761", "CA");
            rs8177374_TT_pos.Add("rs12284123", "G");
            rs8177374_TT_pos.Add("rs12277148", "C");
            rs8177374_TT_pos.Add("rs11220237", "T");
            rs8177374_TT_pos.Add("rs11501216", "G");
            rs8177374_TT_pos.Add("rs665677", "G");
            rs8177374_TT_pos.Add("rs540225", "T");
            rs8177374_TT_pos.Add("rs480978", "G");
            rs8177374_TT_pos.Add("rs12287250", "G");
            rs8177374_TT_pos.Add("rs481056", "G");
            rs8177374_TT_pos.Add("rs4937066", "C");
            rs8177374_TT_pos.Add("rs662715", "C");
            rs8177374_TT_pos.Add("rs3740902", "C");
            rs8177374_TT_pos.Add("rs549990", "CA");
            rs8177374_TT_pos.Add("rs622756", "C");
            rs8177374_TT_pos.Add("rs529457", "A");
            rs8177374_TT_pos.Add("rs667782", "T");
            rs8177374_TT_pos.Add("rs2236681", "A");
            rs8177374_TT_pos.Add("rs17525237", "G");
            rs8177374_TT_pos.Add("rs485878", "G");
            rs8177374_TT_pos.Add("rs2272104", "T");
            rs8177374_TT_pos.Add("rs683155", "C");
            rs8177374_TT_pos.Add("rs498025", "G");
            rs8177374_TT_pos.Add("rs12281146", "T");
            rs8177374_TT_pos.Add("rs541545", "T");
            rs8177374_TT_pos.Add("rs576598", "A");
            rs8177374_TT_pos.Add("rs671880", "G");
            rs8177374_TT_pos.Add("rs2471480", "C");
            rs8177374_TT_pos.Add("rs10893448", "T");
            rs8177374_TT_pos.Add("rs4937070", "T");
            rs8177374_TT_pos.Add("rs687822", "C");
            rs8177374_TT_pos.Add("rs557831", "C");
            rs8177374_TT_pos.Add("rs110143", "G");
            rs8177374_TT_pos.Add("rs871675", "AG");
            rs8177374_TT_pos.Add("rs483216", "GA");
            rs8177374_TT_pos.Add("rs634053", "G");
            rs8177374_TT_pos.Add("rs7941400", "T");
            rs8177374_TT_pos.Add("rs12797894", "C");
            rs8177374_TT_pos.Add("rs2155803", "C");
            rs8177374_TT_pos.Add("rs948113", "GA");
            rs8177374_TT_pos.Add("rs12222197", "G");
            rs8177374_TT_pos.Add("rs627761", "A");
            rs8177374_TT_pos.Add("rs4937076", "GA");
            rs8177374_TT_pos.Add("rs3039", "G");
            rs8177374_TT_pos.Add("rs1065398", "CT");
            rs8177374_TT_pos.Add("rs2186754", "GA");
            rs8177374_TT_pos.Add("rs2509616", "CT");
            rs8177374_TT_pos.Add("rs3737336", "T");
            rs8177374_TT_pos.Add("rs684535", "T");
            rs8177374_TT_pos.Add("rs2276061", "G");
            rs8177374_TT_pos.Add("rs618566", "T");
            rs8177374_TT_pos.Add("rs637858", "A");
            rs8177374_TT_pos.Add("rs555397", "G");
            rs8177374_TT_pos.Add("rs4430526", "GA");
            rs8177374_TT_pos.Add("rs560640", "G");
            rs8177374_TT_pos.Add("rs503764", "CT");
            rs8177374_TT_pos.Add("rs676172", "G");
            rs8177374_TT_pos.Add("rs7124748", "TC");
            rs8177374_TT_pos.Add("rs625280", "A");
            rs8177374_TT_pos.Add("rs592036", "A");
            rs8177374_TT_pos.Add("rs684805", "G");
            rs8177374_TT_pos.Add("rs11220301", "C");
            rs8177374_TT_pos.Add("rs522643", "C");
            rs8177374_TT_pos.Add("rs658305", "C");
            rs8177374_TT_pos.Add("rs486304", "GA");
            rs8177374_TT_pos.Add("rs678440", "C");
            rs8177374_TT_pos.Add("rs2155355", "T");
            rs8177374_TT_pos.Add("rs2298477", "C");
            rs8177374_TT_pos.Add("rs599702", "C");
            rs8177374_TT_pos.Add("rs636865", "G");
            rs8177374_TT_pos.Add("rs575334", "C");
            rs8177374_TT_pos.Add("rs12274729", "C");
            rs8177374_TT_pos.Add("rs12274923", "G");
            rs8177374_TT_pos.Add("rs675864", "C");
            rs8177374_TT_pos.Add("rs7104123", "C");
            rs8177374_TT_pos.Add("rs7104745", "AG");
            rs8177374_TT_pos.Add("rs528638", "GT");
            rs8177374_TT_pos.Add("rs11220311", "C");
            rs8177374_TT_pos.Add("rs517835", "T");
            rs8177374_TT_pos.Add("rs7945668", "CT");
            rs8177374_TT_pos.Add("rs7119527", "C");
            rs8177374_TT_pos.Add("rs3740909", "C");
            rs8177374_TT_pos.Add("rs3740912", "T");
            rs8177374_TT_pos.Add("rs7122277", "T");
            rs8177374_TT_pos.Add("rs11220316", "T");
            rs8177374_TT_pos.Add("rs1939890", "C");
            rs8177374_TT_pos.Add("rs10458992", "G");
            rs8177374_TT_pos.Add("rs11606876", "C");
            rs8177374_TT_pos.Add("rs651284", "C");
            rs8177374_TT_pos.Add("rs508173", "A");
            rs8177374_TT_pos.Add("rs476707", "C");
            rs8177374_TT_pos.Add("rs662947", "TC");
            rs8177374_TT_pos.Add("rs11220321", "C");
            rs8177374_TT_pos.Add("rs543970", "T");
            rs8177374_TT_pos.Add("rs538107", "GA");
            rs8177374_TT_pos.Add("rs718443", "C");
            rs8177374_TT_pos.Add("rs11220329", "T");
            rs8177374_TT_pos.Add("rs472650", "C");
            rs8177374_TT_pos.Add("rs2043436", "C");
            rs8177374_TT_pos.Add("rs2043438", "T");
            rs8177374_TT_pos.Add("rs473075", "GA");
            rs8177374_TT_pos.Add("rs564327", "T");
            rs8177374_TT_pos.Add("rs7119002", "G");
            rs8177374_TT_pos.Add("rs532559", "T");
            rs8177374_TT_pos.Add("rs527123", "T");
            rs8177374_TT_pos.Add("rs472559", "C");
            rs8177374_TT_pos.Add("rs10893475", "T");
            rs8177374_TT_pos.Add("rs651054", "T");
            rs8177374_TT_pos.Add("rs485064", "T");
            rs8177374_TT_pos.Add("rs4935955", "G");
            rs8177374_TT_pos.Add("rs4937090", "A");
            rs8177374_TT_pos.Add("rs12808304", "G");
            rs8177374_TT_pos.Add("rs4937097", "T");
            rs8177374_TT_pos.Add("rs4937098", "C");
            rs8177374_TT_pos.Add("rs564216", "T");
            rs8177374_TT_pos.Add("rs17135097", "G");
            rs8177374_TT_pos.Add("rs12795043", "G");
            rs8177374_TT_pos.Add("rs4448703", "C");
            rs8177374_TT_pos.Add("rs545830", "T");
            rs8177374_TT_pos.Add("rs681223", "G");
            rs8177374_TT_pos.Add("rs684407", "TC");
            rs8177374_TT_pos.Add("rs511987", "T");
            rs8177374_TT_pos.Add("rs543969", "A");
            rs8177374_TT_pos.Add("rs478951", "G");
            rs8177374_TT_pos.Add("rs533239", "G");
            rs8177374_TT_pos.Add("rs10790787", "T");
            rs8177374_TT_pos.Add("rs596077", "A");
            rs8177374_TT_pos.Add("rs581935", "T");
            rs8177374_TT_pos.Add("rs670346", "T");
            rs8177374_TT_pos.Add("rs2278451", "C");
            rs8177374_TT_pos.Add("rs584129", "A");
            rs8177374_TT_pos.Add("rs634973", "C");
            rs8177374_TT_pos.Add("rs10750322", "G");
            rs8177374_TT_pos.Add("rs607980", "A");
            rs8177374_TT_pos.Add("rs621381", "T");
            rs8177374_TT_pos.Add("rs7930128", "G");
            rs8177374_TT_pos.Add("rs650735", "C");
            rs8177374_TT_pos.Add("rs534916", "T");
            rs8177374_TT_pos.Add("rs11220370", "G");
            rs8177374_TT_pos.Add("rs1106944", "T");
            rs8177374_TT_pos.Add("rs632289", "G");
            rs8177374_TT_pos.Add("rs556645", "C");
            rs8177374_TT_pos.Add("rs541601", "C");
            rs8177374_TT_pos.Add("rs4937105", "G");
            rs8177374_TT_pos.Add("rs483611", "G");
            rs8177374_TT_pos.Add("rs595004", "G");
            rs8177374_TT_pos.Add("rs522681", "G");
            rs8177374_TT_pos.Add("rs892424", "G");
            rs8177374_TT_pos.Add("rs11220381", "C");
            rs8177374_TT_pos.Add("rs12098952", "G");
            rs8177374_TT_pos.Add("rs12421177", "C");
            rs8177374_TT_pos.Add("rs3133084", "A");
            rs8177374_TT_pos.Add("rs563519", "T");
            rs8177374_TT_pos.Add("rs10501858", "G");
            rs8177374_TT_pos.Add("rs11220385", "G");
            rs8177374_TT_pos.Add("rs11220386", "A");
            rs8177374_TT_pos.Add("rs732430", "A");
            rs8177374_TT_pos.Add("rs732431", "G");
            rs8177374_TT_pos.Add("rs614918", "T");
            rs8177374_TT_pos.Add("rs613214", "A");
            rs8177374_TT_pos.Add("rs549340", "A");
            rs8177374_TT_pos.Add("rs679736", "G");
            rs8177374_TT_pos.Add("rs574943", "G");
            rs8177374_TT_pos.Add("rs649142", "C");
            rs8177374_TT_pos.Add("rs9645654", "C");
            rs8177374_TT_pos.Add("rs7106095", "G");
            rs8177374_TT_pos.Add("rs561164", "A");
            rs8177374_TT_pos.Add("rs663714", "T");
            rs8177374_TT_pos.Add("rs12419651", "A");
            rs8177374_TT_pos.Add("rs12418362", "T");
            rs8177374_TT_pos.Add("rs4937109", "C");
            rs8177374_TT_pos.Add("rs534278", "A");
            rs8177374_TT_pos.Add("rs644050", "T");
            rs8177374_TT_pos.Add("rs632918", "A");
            rs8177374_TT_pos.Add("rs562731", "A");
            rs8177374_TT_pos.Add("rs567606", "T");
            rs8177374_TT_pos.Add("rs686646", "A");
            rs8177374_TT_pos.Add("rs555228", "G");
            rs8177374_TT_pos.Add("rs670712", "A");
            rs8177374_TT_pos.Add("rs561514", "T");
            rs8177374_TT_pos.Add("rs11220401", "C");
            rs8177374_TT_pos.Add("rs681664", "C");
            rs8177374_TT_pos.Add("rs679387", "C");
            rs8177374_TT_pos.Add("rs530587", "G");
            rs8177374_TT_pos.Add("rs515917", "C");
            rs8177374_TT_pos.Add("rs527051", "C");
            rs8177374_TT_pos.Add("rs693789", "A");
            rs8177374_TT_pos.Add("rs12416718", "C");
            rs8177374_TT_pos.Add("rs574198", "C");
            rs8177374_TT_pos.Add("rs7123264", "C");
            rs8177374_TT_pos.Add("rs480153", "C");
            rs8177374_TT_pos.Add("rs627911", "T");
            rs8177374_TT_pos.Add("rs2276312", "A");
            rs8177374_TT_pos.Add("rs602735", "A");
            rs8177374_TT_pos.Add("rs587891", "C");
            rs8177374_TT_pos.Add("rs2282580", "C");
            rs8177374_TT_pos.Add("rs4420285", "T");
            rs8177374_TT_pos.Add("rs547862", "C");
            rs8177374_TT_pos.Add("rs3851111", "T");
            rs8177374_TT_pos.Add("rs588361", "A");
            rs8177374_TT_pos.Add("rs11220405", "T");
            rs8177374_TT_pos.Add("rs512577", "C");
            rs8177374_TT_pos.Add("rs11220409", "G");
            rs8177374_TT_pos.Add("rs618176", "C");
            rs8177374_TT_pos.Add("rs2936610", "T");
            rs8177374_TT_pos.Add("rs10893490", "T");
            rs8177374_TT_pos.Add("rs670154", "A");
            rs8177374_TT_pos.Add("rs17656", "C");
            rs8177374_TT_pos.Add("rs1049666", "A");
            rs8177374_TT_pos.Add("rs1049665", "T");
            rs8177374_TT_pos.Add("rs529328", "G");
            rs8177374_TT_pos.Add("rs499205", "A");
            rs8177374_TT_pos.Add("rs11220432", "G");
            rs8177374_TT_pos.Add("rs2962118", "C");
            rs8177374_TT_pos.Add("rs12786155", "T");
            rs8177374_TT_pos.Add("rs1786702", "C");
            rs8177374_TT_pos.Add("rs478309", "G");
            rs8177374_TT_pos.Add("rs2298452", "C");
            rs8177374_TT_pos.Add("rs667627", "G");
            rs8177374_TT_pos.Add("rs10893493", "A");
            rs8177374_TT_pos.Add("rs8177368", "C");
            rs8177374_TT_pos.Add("rs1893352", "G");
            rs8177374_TT_pos.Add("rs8177399", "C");
            rs8177374_TT_pos.Add("rs3802813", "G");
            rs8177374_TT_pos.Add("rs8177400", "G");
            rs8177374_TT_pos.Add("rs3802814", "A");
            rs8177374_TT_pos.Add("rs8177374", "T");
            rs8177374_TT_pos.Add("rs7932766", "C");
            rs8177374_TT_pos.Add("rs8177375", "A");
            rs8177374_TT_pos.Add("rs8177376", "T");
            rs8177374_TT_pos.Add("rs625413", "C");
            rs8177374_TT_pos.Add("rs1786700", "A");
            rs8177374_TT_pos.Add("rs3740915", "C");
            rs8177374_TT_pos.Add("rs695029", "C");
            rs8177374_TT_pos.Add("rs637462", "A");
            rs8177374_TT_pos.Add("rs2096914", "G");
            rs8177374_TT_pos.Add("rs1111930", "G");
            rs8177374_TT_pos.Add("rs583697", "T");
            rs8177374_TT_pos.Add("rs12788021", "A");
            rs8177374_TT_pos.Add("rs683800", "T");
            rs8177374_TT_pos.Add("rs624259", "G");
            rs8177374_TT_pos.Add("rs611593", "G");
            rs8177374_TT_pos.Add("rs611151", "C");
            rs8177374_TT_pos.Add("rs10893496", "C");
            rs8177374_TT_pos.Add("rs601580", "T");
            rs8177374_TT_pos.Add("rs1695739", "A");
            rs8177374_TT_pos.Add("rs586566", "C");
            rs8177374_TT_pos.Add("rs651922", "A");
            rs8177374_TT_pos.Add("rs646358", "T");
            rs8177374_TT_pos.Add("rs240543", "G");
            rs8177374_TT_pos.Add("rs7115672", "T");
            rs8177374_TT_pos.Add("rs240542", "C");
            rs8177374_TT_pos.Add("rs240537", "G");
            rs8177374_TT_pos.Add("rs171269", "C");
            rs8177374_TT_pos.Add("rs582037", "C");
            rs8177374_TT_pos.Add("rs17135399", "A");
            rs8177374_TT_pos.Add("rs583823", "G");
            rs8177374_TT_pos.Add("rs2848583", "C");
            rs8177374_TT_pos.Add("rs4937122", "T");
            rs8177374_TT_pos.Add("rs12226757", "C");
            rs8177374_TT_pos.Add("rs10893499", "G");
            rs8177374_TT_pos.Add("rs629882", "T");
            rs8177374_TT_pos.Add("rs3862628", "G");
            rs8177374_TT_pos.Add("rs3862629", "C");
            rs8177374_TT_pos.Add("rs4601794", "A");
            rs8177374_TT_pos.Add("rs7940893", "T");
            rs8177374_TT_pos.Add("rs11220463", "A");
            rs8177374_TT_pos.Add("rs10893500", "T");
            rs8177374_TT_pos.Add("rs10893502", "T");
            rs8177374_TT_pos.Add("rs11220465", "G");
            rs8177374_TT_pos.Add("rs7118117", "A");
            rs8177374_TT_pos.Add("rs2186717", "G");
            rs8177374_TT_pos.Add("rs7928391", "C");
            rs8177374_TT_pos.Add("rs12280645", "A");
            rs8177374_TT_pos.Add("rs11220473", "A");
            rs8177374_TT_pos.Add("rs12574844", "G");
            rs8177374_TT_pos.Add("rs1007690", "T");
            rs8177374_TT_pos.Add("rs6590202", "T");
            rs8177374_TT_pos.Add("rs6590203", "A");
            rs8177374_TT_pos.Add("rs11220476", "C");
            rs8177374_TT_pos.Add("rs11220477", "C");
            rs8177374_TT_pos.Add("rs11603211", "G");
            rs8177374_TT_pos.Add("rs2230279", "C");
            rs8177374_TT_pos.Add("rs2298475", "T");
            rs8177374_TT_pos.Add("rs2236653", "C");
            rs8177374_TT_pos.Add("rs11220483", "C");
            rs8177374_TT_pos.Add("rs4935966", "C");
            rs8177374_TT_pos.Add("rs4935967", "A");
            rs8177374_TT_pos.Add("rs4937128", "A");
            rs8177374_TT_pos.Add("rs4553380", "G");
            rs8177374_TT_pos.Add("rs948054", "G");
            rs8177374_TT_pos.Add("rs7113465", "C");
            rs8177374_TT_pos.Add("rs3802815", "T");
            rs8177374_TT_pos.Add("i5007338", "C");
            rs8177374_TT_pos.Add("rs4935969", "C");
            rs8177374_TT_pos.Add("rs6590206", "CT");
            rs8177374_TT_pos.Add("rs11220490", "C");
            rs8177374_TT_pos.Add("rs4937131", "G");
            rs8177374_TT_pos.Add("rs11220494", "A");
            rs8177374_TT_pos.Add("rs3740917", "A");
            rs8177374_TT_pos.Add("rs3740918", "G");
            rs8177374_TT_pos.Add("rs3212313", "T");
            rs8177374_TT_pos.Add("rs3802819", "C");
            rs8177374_TT_pos.Add("rs3802820", "C");
            rs8177374_TT_pos.Add("rs3802821", "G");
            rs8177374_TT_pos.Add("rs4294574", "TC");
            rs8177374_TT_pos.Add("i5007337", "C");
            rs8177374_TT_pos.Add("rs7936304", "G");
            rs8177374_TT_pos.Add("rs11220500", "C");
            rs8177374_TT_pos.Add("rs12801239", "T");
            rs8177374_TT_pos.Add("rs3809005", "C");
            rs8177374_TT_pos.Add("rs11220501", "G");
            rs8177374_TT_pos.Add("rs2155309", "C");
            rs8177374_TT_pos.Add("rs7946496", "C");
            rs8177374_TT_pos.Add("rs11220503", "C");
            rs8177374_TT_pos.Add("rs11220504", "T");
            rs8177374_TT_pos.Add("rs7925175", "AC");
            rs8177374_TT_pos.Add("rs3903109", "C");
            rs8177374_TT_pos.Add("rs1124515", "G");
            rs8177374_TT_pos.Add("rs11220516", "C");
            rs8177374_TT_pos.Add("rs4937139", "A");
            rs8177374_TT_pos.Add("rs10893525", "CT");
            rs8177374_TT_pos.Add("rs11220521", "G");
            rs8177374_TT_pos.Add("rs1000256", "A");
            rs8177374_TT_pos.Add("rs1000255", "A");
            rs8177374_TT_pos.Add("rs1000254", "C");
            rs8177374_TT_pos.Add("rs7937654", "T");
            rs8177374_TT_pos.Add("rs10160702", "T");
            rs8177374_TT_pos.Add("rs1892999", "C");
            rs8177374_TT_pos.Add("rs4937142", "GA");
            rs8177374_TT_pos.Add("rs10750326", "G");
            rs8177374_TT_pos.Add("rs11823106", "A");
            rs8177374_TT_pos.Add("rs7933568", "G");
            rs8177374_TT_pos.Add("rs7127176", "C");
            rs8177374_TT_pos.Add("rs7933515", "C");
            rs8177374_TT_pos.Add("rs12803511", "G");
            rs8177374_TT_pos.Add("rs12803395", "C");
            rs8177374_TT_pos.Add("rs2155314", "T");
            rs8177374_TT_pos.Add("rs7927708", "C");
            rs8177374_TT_pos.Add("rs7941193", "G");
            rs8177374_TT_pos.Add("rs10128646", "A");
            rs8177374_TT_pos.Add("rs10893526", "CT");
            rs8177374_TT_pos.Add("rs11826881", "A");
            rs8177374_TT_pos.Add("rs6590216", "G");
            rs8177374_TT_pos.Add("rs4937146", "T");
            rs8177374_TT_pos.Add("rs4341546", "A");
            rs8177374_TT_pos.Add("rs4471434", "T");
            rs8177374_TT_pos.Add("rs12270348", "A");
            rs8177374_TT_pos.Add("rs558745", "C");
            rs8177374_TT_pos.Add("rs11605603", "C");
            rs8177374_TT_pos.Add("rs12269776", "T");
            rs8177374_TT_pos.Add("rs1892996", "T");
            rs8177374_TT_pos.Add("rs674537", "A");
            rs8177374_TT_pos.Add("rs620082", "C");
            rs8177374_TT_pos.Add("rs4937148", "C");
            rs8177374_TT_pos.Add("rs12269946", "G");
            rs8177374_TT_pos.Add("rs1784230", "G");
            rs8177374_TT_pos.Add("rs552640", "CA");
            rs8177374_TT_pos.Add("rs628570", "C");
            rs8177374_TT_pos.Add("rs12278937", "C");
            rs8177374_TT_pos.Add("rs1939299", "T");
            rs8177374_TT_pos.Add("rs527629", "CT");
            rs8177374_TT_pos.Add("rs659953", "A");
            rs8177374_TT_pos.Add("rs12291500", "T");
            rs8177374_TT_pos.Add("rs4937150", "A");
            rs8177374_TT_pos.Add("rs513444", "G");
            rs8177374_TT_pos.Add("rs667483", "G");
            rs8177374_TT_pos.Add("rs573245", "C");
            rs8177374_TT_pos.Add("rs657320", "G");
            rs8177374_TT_pos.Add("rs10893539", "A");
            rs8177374_TT_pos.Add("rs7931414", "T");
            rs8177374_TT_pos.Add("rs485645", "CT");
            rs8177374_TT_pos.Add("rs487842", "G");
            rs8177374_TT_pos.Add("rs489725", "G");
            rs8177374_TT_pos.Add("rs491536", "C");
            rs8177374_TT_pos.Add("rs619996", "GA");
            rs8177374_TT_pos.Add("rs681653", "G");
            rs8177374_TT_pos.Add("rs947949", "C");
            rs8177374_TT_pos.Add("rs639294", "A");
            rs8177374_TT_pos.Add("rs654393", "GA");
            rs8177374_TT_pos.Add("rs632023", "AC");
            rs8177374_TT_pos.Add("rs537172", "T");
            rs8177374_TT_pos.Add("rs4937154", "A");
            rs8177374_TT_pos.Add("rs2004770", "G");
            rs8177374_TT_pos.Add("rs618745", "C");
            rs8177374_TT_pos.Add("rs12574555", "T");
            rs8177374_TT_pos.Add("rs541969", "CT");
            rs8177374_TT_pos.Add("rs578341", "G");
            rs8177374_TT_pos.Add("rs605344", "T");
            rs8177374_TT_pos.Add("rs573946", "A");
            rs8177374_TT_pos.Add("rs12794212", "C");
            rs8177374_TT_pos.Add("rs10893545", "T");
            rs8177374_TT_pos.Add("rs484820", "TC");
            rs8177374_TT_pos.Add("rs480073", "G");
            rs8177374_TT_pos.Add("rs11604082", "T");
            rs8177374_TT_pos.Add("rs608006", "T");
            rs8177374_TT_pos.Add("rs535603", "G");
            rs8177374_TT_pos.Add("rs474130", "A");
            rs8177374_TT_pos.Add("rs471302", "C");
            rs8177374_TT_pos.Add("rs577149", "G");
            rs8177374_TT_pos.Add("rs11220553", "C");
            rs8177374_TT_pos.Add("rs489487", "CT");
            rs8177374_TT_pos.Add("rs684589", "T");
            rs8177374_TT_pos.Add("rs483027", "C");
            rs8177374_TT_pos.Add("rs1649103", "T");
            rs8177374_TT_pos.Add("rs7124593", "G");
            rs8177374_TT_pos.Add("rs493725", "C");
            rs8177374_TT_pos.Add("rs641675", "C");
            rs8177374_TT_pos.Add("rs4937159", "G");
            rs8177374_TT_pos.Add("rs549190", "A");
            rs8177374_TT_pos.Add("rs11220561", "C");
            rs8177374_TT_pos.Add("rs559121", "C");
            rs8177374_TT_pos.Add("rs681570", "C");
            rs8177374_TT_pos.Add("rs569694", "G");
            rs8177374_TT_pos.Add("rs876901", "GT");
            rs8177374_TT_pos.Add("rs514457", "G");
            rs8177374_TT_pos.Add("rs879164", "A");
            rs8177374_TT_pos.Add("rs625993", "G");
            rs8177374_TT_pos.Add("rs4937166", "C");
            rs8177374_TT_pos.Add("rs10790817", "C");
            rs8177374_TT_pos.Add("rs999550", "A");
            rs8177374_TT_pos.Add("rs11220566", "GA");
            rs8177374_TT_pos.Add("rs658125", "A");
            rs8177374_TT_pos.Add("rs544207", "C");
            rs8177374_TT_pos.Add("rs11220571", "A");
            rs8177374_TT_pos.Add("rs1318969", "A");
            rs8177374_TT_pos.Add("rs1783988", "G");
            rs8177374_TT_pos.Add("rs509759", "CT");
            rs8177374_TT_pos.Add("rs2155163", "T");
            rs8177374_TT_pos.Add("rs4937170", "T");
            rs8177374_TT_pos.Add("rs523249", "G");
            rs8177374_TT_pos.Add("rs693253", "GA");
            rs8177374_TT_pos.Add("rs7950175", "T");
            rs8177374_TT_pos.Add("rs7108068", "G");
            rs8177374_TT_pos.Add("rs2156449", "A");
            rs8177374_TT_pos.Add("rs11220578", "T");
            rs8177374_TT_pos.Add("rs4112714", "C");
            rs8177374_TT_pos.Add("rs11826700", "A");
            rs8177374_TT_pos.Add("rs11220583", "T");
            rs8177374_TT_pos.Add("rs7128945", "C");
            rs8177374_TT_pos.Add("rs4937179", "C");
            rs8177374_TT_pos.Add("rs7123354", "A");
            rs8177374_TT_pos.Add("rs11220587", "G");
            rs8177374_TT_pos.Add("rs3862634", "G");
            rs8177374_TT_pos.Add("rs4935985", "A");
            rs8177374_TT_pos.Add("rs10790820", "A");
            rs8177374_TT_pos.Add("rs4581457", "G");
            rs8177374_TT_pos.Add("rs3909729", "CT");
            rs8177374_TT_pos.Add("rs3909725", "A");
            rs8177374_TT_pos.Add("rs12291492", "CT");
            rs8177374_TT_pos.Add("rs7933188", "C");
            rs8177374_TT_pos.Add("rs3909723", "T");
            rs8177374_TT_pos.Add("rs6590227", "C");
            rs8177374_TT_pos.Add("rs3911927", "C");
            rs8177374_TT_pos.Add("rs3926407", "T");
            rs8177374_TT_pos.Add("rs4099577", "A");
            rs8177374_TT_pos.Add("rs4245068", "A");
            rs8177374_TT_pos.Add("rs7949667", "GA");
            rs8177374_TT_pos.Add("rs12807269", "T");
            rs8177374_TT_pos.Add("rs3909722", "T");
            rs8177374_TT_pos.Add("rs11220594", "C");
            rs8177374_TT_pos.Add("rs10893557", "GT");
            rs8177374_TT_pos.Add("rs3862639", "C");
            rs8177374_TT_pos.Add("rs4935986", "CA");
            rs8177374_TT_pos.Add("rs4935987", "CT");
            rs8177374_TT_pos.Add("rs7131158", "T");
            rs8177374_TT_pos.Add("rs10893559", "AG");
            rs8177374_TT_pos.Add("rs7944781", "G");
            rs8177374_TT_pos.Add("rs3862642", "C");
            rs8177374_TT_pos.Add("rs12419324", "C");
            rs8177374_TT_pos.Add("rs3862645", "G");
            rs8177374_TT_pos.Add("rs3889461", "T");
            rs8177374_TT_pos.Add("rs1106419", "G");
            rs8177374_TT_pos.Add("rs4937181", "T");
            rs8177374_TT_pos.Add("rs10893560", "AG");
            rs8177374_TT_pos.Add("rs7131312", "G");
            rs8177374_TT_pos.Add("rs1946091", "AG");
            rs8177374_TT_pos.Add("rs11220596", "G");
            rs8177374_TT_pos.Add("rs13377256", "T");
            rs8177374_TT_pos.Add("rs1557488", "C");
            rs8177374_TT_pos.Add("rs1946089", "TC");
            rs8177374_TT_pos.Add("rs11220599", "A");
            rs8177374_TT_pos.Add("rs952316", "C");
            rs8177374_TT_pos.Add("rs4935990", "A");
            rs8177374_TT_pos.Add("rs1946086", "A");
            rs8177374_TT_pos.Add("rs1946084", "GA");
            rs8177374_TT_pos.Add("rs7101595", "T");
            rs8177374_TT_pos.Add("rs1540238", "GT");
            rs8177374_TT_pos.Add("rs10082694", "GA");
            rs8177374_TT_pos.Add("rs11220605", "C");
            rs8177374_TT_pos.Add("rs1946075", "C");
            rs8177374_TT_pos.Add("rs12792630", "G");
            rs8177374_TT_pos.Add("rs10893567", "T");
            rs8177374_TT_pos.Add("rs1874", "G");
            rs8177374_TT_pos.Add("rs939530", "C");
            rs8177374_TT_pos.Add("rs11220606", "G");
            rs8177374_TT_pos.Add("rs11220608", "A");
            rs8177374_TT_pos.Add("rs10790827", "C");
            rs8177374_TT_pos.Add("rs10790829", "CT");
            rs8177374_TT_pos.Add("rs9326286", "T");
            rs8177374_TT_pos.Add("rs4937186", "GA");
            rs8177374_TT_pos.Add("rs10893569", "GT");
            rs8177374_TT_pos.Add("rs4935994", "GA");
            rs8177374_TT_pos.Add("rs1946046", "C");
            rs8177374_TT_pos.Add("rs2000970", "T");
            rs8177374_TT_pos.Add("rs7109451", "C");
            rs8177374_TT_pos.Add("rs10790834", "A");
            rs8177374_TT_pos.Add("rs10893574", "T");
            rs8177374_TT_pos.Add("rs11220621", "T");
            rs8177374_TT_pos.Add("rs1946053", "GA");
            rs8177374_TT_pos.Add("rs10790836", "C");
            rs8177374_TT_pos.Add("rs11220623", "G");
            rs8177374_TT_pos.Add("rs10790837", "G");
            rs8177374_TT_pos.Add("rs1946065", "A");
            rs8177374_TT_pos.Add("rs1894222", "A");
            rs8177374_TT_pos.Add("rs2027787", "C");
            rs8177374_TT_pos.Add("rs10750352", "TC");
            rs8177374_TT_pos.Add("rs11220632", "G");
            rs8177374_TT_pos.Add("rs10790844", "GA");
            rs8177374_TT_pos.Add("rs939512", "G");
            rs8177374_TT_pos.Add("rs7102782", "T");
            rs8177374_TT_pos.Add("rs7129447", "A");
            rs8177374_TT_pos.Add("rs7111405", "A");
            rs8177374_TT_pos.Add("rs7126443", "G");
            rs8177374_TT_pos.Add("rs9888281", "A");
            rs8177374_TT_pos.Add("rs4936001", "A");
            rs8177374_TT_pos.Add("rs1784354", "A");
            rs8177374_TT_pos.Add("rs10790850", "A");
            rs8177374_TT_pos.Add("rs7109913", "A");
            rs8177374_TT_pos.Add("rs4937214", "CT");
            rs8177374_TT_pos.Add("rs1939988", "TC");
            rs8177374_TT_pos.Add("rs4936003", "T");
            rs8177374_TT_pos.Add("rs7924535", "AG");
            rs8177374_TT_pos.Add("rs1940006", "AG");
            rs8177374_TT_pos.Add("rs1009567", "TC");
            rs8177374_TT_pos.Add("rs10750355", "GA");
            rs8177374_TT_pos.Add("rs10750356", "TC");
            rs8177374_TT_pos.Add("rs2282507", "C");
            rs8177374_TT_pos.Add("rs12275052", "C");
            rs8177374_TT_pos.Add("rs11600756", "C");
            rs8177374_TT_pos.Add("rs4937216", "G");
            rs8177374_TT_pos.Add("rs948122", "TC");
            rs8177374_TT_pos.Add("rs1784343", "A");
            rs8177374_TT_pos.Add("rs1793656", "G");
            rs8177374_TT_pos.Add("rs6590235", "C");
            rs8177374_TT_pos.Add("rs7928765", "G");
            rs8177374_TT_pos.Add("rs1784336", "CT");
            rs8177374_TT_pos.Add("rs12787569", "T");
            rs8177374_TT_pos.Add("rs1627921", "G");
            rs8177374_TT_pos.Add("rs1793660", "A");
            rs8177374_TT_pos.Add("rs11220660", "G");
            rs8177374_TT_pos.Add("rs1620264", "C");
            rs8177374_TT_pos.Add("rs1793668", "TC");
            rs8177374_TT_pos.Add("rs1784318", "CT");
            rs8177374_TT_pos.Add("rs2434981", "G");
            rs8177374_TT_pos.Add("rs948124", "G");
            rs8177374_TT_pos.Add("rs6590236", "GA");
            rs8177374_TT_pos.Add("rs1793675", "G");
            rs8177374_TT_pos.Add("rs1939992", "C");
            rs8177374_TT_pos.Add("rs1894225", "C");
            rs8177374_TT_pos.Add("rs1793673", "A");
            rs8177374_TT_pos.Add("rs2000971", "A");
            rs8177374_TT_pos.Add("rs1894224", "C");
            rs8177374_TT_pos.Add("rs11220674", "C");
            rs8177374_TT_pos.Add("rs12283529", "G");
            rs8177374_TT_pos.Add("rs7125248", "G");
            rs8177374_TT_pos.Add("rs619086", "A");
            rs8177374_TT_pos.Add("rs10893608", "G");
            rs8177374_TT_pos.Add("rs664602", "T");
            rs8177374_TT_pos.Add("rs2040339", "C");
            rs8177374_TT_pos.Add("rs625987", "G");
            rs8177374_TT_pos.Add("rs11220685", "T");
            rs8177374_TT_pos.Add("rs583795", "G");
            rs8177374_TT_pos.Add("rs4937222", "A");
            rs8177374_TT_pos.Add("rs1939995", "G");
            rs8177374_TT_pos.Add("rs1939996", "G");
            rs8177374_TT_pos.Add("rs646236", "G");
            rs8177374_TT_pos.Add("rs631562", "CA");
            rs8177374_TT_pos.Add("rs669765", "T");
            rs8177374_TT_pos.Add("rs653856", "A");
            rs8177374_TT_pos.Add("rs541783", "G");
            rs8177374_TT_pos.Add("rs522686", "C");
            rs8177374_TT_pos.Add("rs3802823", "G");
            rs8177374_TT_pos.Add("rs2508557", "T");
            rs8177374_TT_pos.Add("rs494442", "C");
            rs8177374_TT_pos.Add("rs7941136", "A");
            rs8177374_TT_pos.Add("rs7941545", "G");
            rs8177374_TT_pos.Add("rs676846", "T");
            rs8177374_TT_pos.Add("rs684451", "G");
            rs8177374_TT_pos.Add("rs562515", "A");
            rs8177374_TT_pos.Add("rs11220708", "T");
            rs8177374_TT_pos.Add("rs1944623", "A");
            rs8177374_TT_pos.Add("rs611849", "C");
            rs8177374_TT_pos.Add("rs521381", "T");
            rs8177374_TT_pos.Add("rs610505", "A");
            rs8177374_TT_pos.Add("rs1944622", "G");
            rs8177374_TT_pos.Add("rs11220710", "C");
            rs8177374_TT_pos.Add("rs11220712", "T");
            rs8177374_TT_pos.Add("rs10466610", "T");
            rs8177374_TT_pos.Add("rs1939228", "A");
            rs8177374_TT_pos.Add("rs7103671", "A");
            rs8177374_TT_pos.Add("rs11600665", "T");
            rs8177374_TT_pos.Add("rs11220720", "T");
            rs8177374_TT_pos.Add("rs7102500", "T");
            rs8177374_TT_pos.Add("rs11220722", "C");
            rs8177374_TT_pos.Add("rs1944627", "G");
            rs8177374_TT_pos.Add("rs7129845", "A");
            rs8177374_TT_pos.Add("rs483644", "A");
            rs8177374_TT_pos.Add("rs11220729", "C");
            rs8177374_TT_pos.Add("rs508800", "T");
            rs8177374_TT_pos.Add("rs7931141", "T");

           

        }

        public byte[] Zip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        public byte[] Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return mso.ToArray();
            }
        }

        public void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                int result = checkIBD(dialog.FileName, rs8177374_TT_pos, "rs8177374", "11", "TT");

                if (result == RESULT_NA)
                    MessageBox.Show("Insufficient Data.");
                else if (result == RESULT_TRUE)
                    MessageBox.Show("Yes! You have resistance to several diseases including malaria, tuberculosis, bacteremia and pneumococcal disease.");
                else if(result==RESULT_PROB_TRUE)
                    MessageBox.Show("You may have resistance to several diseases including malaria, tuberculosis, bacteremia and pneumococcal disease.");
                else if(result==RESULT_FALSE)
                    MessageBox.Show("Sorry, you don't have resistance to malaria, tuberculosis, bacteremia and pneumococcal disease.");
            }
        }

        private int checkIBD(string file, Dictionary<string, string> ibd_gt_ref, string rsid, string chr, string target_gt)
        {
            List<string> match = new List<string>();
            string text = getAutosomalText(file);

            StringReader reader = new StringReader(text);
            string line = null;
            string[] data = null;
            bool is_match = true;
            int error_count = 0;
            int allowed_errors = ibd_gt_ref.Count * 4 / 100;
            //StringBuilder stmp = new StringBuilder();
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("#") || line.StartsWith("RSID") || line.StartsWith("rsid"))
                    continue;
                line = line.Replace("\"", "").Replace("\t", ",");
                data = line.Split(new char[] { ',' });
                if (data.Length == 5)
                    data[3] = data[3] + data[4];

                if (data[1] == chr)
                {
                    //stmp.Append(line);
                    //stmp.Append("\r\n");

                    if (data[0] == rsid)
                    {
                        if (data[3] == target_gt)
                            return RESULT_TRUE;
                        else
                            return RESULT_FALSE;
                    }

                    if (ibd_gt_ref.ContainsKey(data[0]))
                    {
                        if (ibd_gt_ref[data[0]].Length == 1)
                        {
                            if (ibd_gt_ref[data[0]] == data[3][0].ToString() || ibd_gt_ref[data[0]] == data[3][1].ToString())
                                match.Add(data[0]);
                            else
                            {
                                if (data[3].IndexOf("-") != -1 || data[3].IndexOf("0") != -1 || data[3].IndexOf("?") != -1)
                                    continue;

                                error_count++;
                                if (error_count >= allowed_errors)
                                {
                                    is_match = false;
                                    break;
                                }
                                else
                                    match.Add(data[0]);
                            }
                        }
                        else if (ibd_gt_ref[data[0]].Length == 2)
                        {
                            if (ibd_gt_ref[data[0]][0].ToString() == data[3][0].ToString() ||
                                ibd_gt_ref[data[0]][0].ToString() == data[3][1].ToString() ||
                                ibd_gt_ref[data[0]][1].ToString() == data[3][0].ToString() ||
                                ibd_gt_ref[data[0]][1].ToString() == data[3][1].ToString())
                                match.Add(data[0]);
                            else
                            {
                                if (data[3].IndexOf("-") != -1 || data[3].IndexOf("0") != -1 || data[3].IndexOf("?") != -1)
                                    continue;

                                error_count++;
                                if (error_count >= allowed_errors)
                                {
                                    is_match = false;
                                    break;
                                }
                                else
                                    match.Add(data[0]);
                            }
                        }
                        else
                        {
                            if (data[3].IndexOf("-") != -1 || data[3].IndexOf("0") != -1 || data[3].IndexOf("?") != -1)
                                continue;

                            error_count++;
                            if (error_count >= allowed_errors)
                            {
                                is_match = false;
                                break;
                            }
                            else
                                match.Add(data[0]);
                        }
                    }
                }
            }

            //File.WriteAllText(@"D:\Temp\" + Path.GetFileName(file) + ".7", stmp.ToString());

            if (is_match)
            {
                if (match.Count >= ibd_gt_ref.Keys.Count * 0.9)
                    return RESULT_TRUE;
                else if (match.Count >= ibd_gt_ref.Keys.Count * 0.5)
                    return RESULT_PROB_TRUE;
                else
                    return RESULT_NA;
            }
            else
            {
                return RESULT_FALSE;
            }
        }

        private string getAutosomalText(string file)
        {
            string text = null;

            if (file.EndsWith(".gz"))
            {
                StringReader reader = new StringReader(Encoding.UTF8.GetString(Unzip(File.ReadAllBytes(file))));
                text = reader.ReadToEnd();
                reader.Close();

            }
            else if (file.EndsWith(".zip"))
            {
                using (var fs = new MemoryStream(File.ReadAllBytes(file)))
                using (var zf = new ZipFile(fs))
                {
                    var ze = zf[0];
                    if (ze == null)
                    {
                        throw new ArgumentException("file not found in Zip");
                    }
                    using (var s = zf.GetInputStream(ze))
                    {
                        using (StreamReader sr = new StreamReader(s))
                        {
                            text = sr.ReadToEnd();
                        }
                    }
                }
            }
            else
                text = File.ReadAllText(file);
            return text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.y-str.org/");
        }
    }
}
