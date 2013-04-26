using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EveAI;
using EveAI.Product;
using EveAI.Live;
using EveAI.Live.Market;
using Google.GData.Client;
using Google.GData.Spreadsheets;

namespace EVEBend
{
    public partial class FormMain : Form
    {
        EveAI.Live.Market.EveCentralMarketApi api = new EveAI.Live.Market.EveCentralMarketApi(new EveApi().EveApiCore);
        private string strLastUpdated = "";
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdExport.Enabled = false;
            lblEditSuccessful.Visible = false;
        }

        private void RetrieveInformation()
        {
            List<EveAI.Product.ProductType> lstPrimaryProducts = new List<EveAI.Product.ProductType>();
            List<EveAI.Product.ProductType> lstSecondaryProducts = new List<EveAI.Product.ProductType>();
            List<EveAI.Product.ProductType> lstTertiaryProducts = new List<EveAI.Product.ProductType>();

            rtbPrices.Text = "";
            Cursor.Current = Cursors.WaitCursor;

            lstPrimaryProducts = EVE.RetrievePrimaryProducts();

            for (int i = 0; i < lstPrimaryProducts.Count; i++)
            {
                EveAI.Live.Market.ProductStatistics Stats = EVE.GetProductInformation(lstPrimaryProducts[i]);

                rtbPrices.Text += lstPrimaryProducts[i].Name + " ";
                rtbPrices.Text += Stats.SellOrders.Median + "\n";
            }

            lstSecondaryProducts = EVE.RetrieveSecondaryProducts();

            for (int i = 0; i < lstSecondaryProducts.Count; i++)
            {
                EveAI.Live.Market.ProductStatistics Stats = EVE.GetProductInformation(lstSecondaryProducts[i]);

                rtbPrices.Text += lstSecondaryProducts[i].Name + " ";
                rtbPrices.Text += Stats.SellOrders.Median + "\n";
            }

            lstTertiaryProducts = EVE.RetrieveTertiaryProducts();

            for (int i = 0; i < lstTertiaryProducts.Count; i++)
            {
                EveAI.Live.Market.ProductStatistics Stats = EVE.GetProductInformation(lstTertiaryProducts[i]);

                rtbPrices.Text += lstTertiaryProducts[i].Name + " ";
                rtbPrices.Text += Stats.SellOrders.Median + "\n";
            }

            strLastUpdated = "Last retrieval: " + DateTime.Now.ToShortTimeString();
            lblNews.Text = strLastUpdated;
            lblNews.Visible = true;
            lblEditSuccessful.Visible = false;
            Cursor.Current = Cursors.Default;
        }

        private void ExportInformation()
        {
            SpreadsheetsService service = new SpreadsheetsService("EVEBendSpreadsheetV1");
            service.setUserCredentials("GOOGLE DOCS USERNAME", "GOOGLE PASSWORD");
            SpreadsheetQuery query = new SpreadsheetQuery();
            SpreadsheetFeed feed = service.Query(query);

            if (feed.Entries.Count == 0)
            {
                EnableButtons();
                lblNews.Visible = false;
                lblEditSuccessful.Text = "Export Failed";
                lblEditSuccessful.Visible = true;
            }
            else
            {
                SpreadsheetEntry spreadsheet = (SpreadsheetEntry)feed.Entries[0];
                if (spreadsheet.Title.Text.ToString() == "Ore Values")
                {
                    rtbPrices.Text += "\nSearching spreadsheet: " + spreadsheet.Title.Text;

                    WorksheetFeed wsFeed = spreadsheet.Worksheets;
                    WorksheetEntry worksheet = (WorksheetEntry)wsFeed.Entries[1];
                    rtbPrices.Text += "\nEditing worksheet: " + worksheet.Title.Text;

                    CellQuery cellQuery = new CellQuery(worksheet.CellFeedLink);
                    CellFeed cellFeed = service.Query(cellQuery);

                    foreach (CellEntry cell in cellFeed.Entries)
                    {
                        if (cell.Title.Text == "C1")
                        {
                            cell.InputValue = DateTime.Now.ToShortDateString().ToString() + " Avg Prices";
                            cell.Update();
                        }

                        #region Cells G2 to N2

                        //Tritanium
                        if (cell.Title.Text == "G2")
                        {
                            cell.InputValue = EVE.Tritanium.ToString();
                            cell.Update();
                        }
                        //Pyerite 
                        if (cell.Title.Text == "H2")
                        {
                            cell.InputValue = EVE.Pyerite.ToString();
                            cell.Update();
                        }
                        //Mexallon 
                        if (cell.Title.Text == "I2")
                        {
                            cell.InputValue = EVE.Mexallon.ToString();
                            cell.Update();
                        }
                        //Isogen 
                        if (cell.Title.Text == "J2")
                        {
                            cell.InputValue = EVE.Isogen.ToString();
                            cell.Update();
                        }
                        //Nocxium 
                        if (cell.Title.Text == "K2")
                        {
                            cell.InputValue = EVE.Nocxium.ToString();
                            cell.Update();
                        }
                        //Zydrine 
                        if (cell.Title.Text == "L2")
                        {
                            cell.InputValue = EVE.Zydrine.ToString();
                            cell.Update();
                        }
                        //Megacyte 
                        if (cell.Title.Text == "M2")
                        {
                            cell.InputValue = EVE.Megacyte.ToString();
                            cell.Update();
                        }
                        //Morphite
                        if (cell.Title.Text == "N2")
                        {
                            cell.InputValue = EVE.Morphite.ToString();
                            cell.Update();
                        }

                        #endregion

                        #region Cells C3 to C23

                        //Veldspar
                        if (cell.Title.Text == "C3")
                        {
                            cell.InputValue = EVE.Veldspar.ToString();
                            cell.Update();
                        }
                        //Concentrated Veldspar
                        if (cell.Title.Text == "C4")
                        {
                            cell.InputValue = EVE.ConcVeldspar.ToString();
                            cell.Update();
                        }
                        //Dense Veldspar
                        if (cell.Title.Text == "C5")
                        {
                            cell.InputValue = EVE.DenseVeldspar.ToString();
                            cell.Update();
                        }
                        //Scordite
                        if (cell.Title.Text == "C6")
                        {
                            cell.InputValue = EVE.Scordite.ToString();
                            cell.Update();
                        }
                        //Condensed Scordite
                        if (cell.Title.Text == "C7")
                        {
                            cell.InputValue = EVE.CondScordite.ToString();
                            cell.Update();
                        }
                        //Massive Scordite
                        if (cell.Title.Text == "C8")
                        {
                            cell.InputValue = EVE.MassScordite.ToString();
                            cell.Update();
                        }
                        //Pyroxeres
                        if (cell.Title.Text == "C9")
                        {
                            cell.InputValue = EVE.Pyroxeres.ToString();
                            cell.Update();
                        }
                        //Solid Pyroxeres 
                        if (cell.Title.Text == "C10")
                        {
                            cell.InputValue = EVE.SolidPyroxeres.ToString();
                            cell.Update();
                        }
                        //Viscous Pyroxeres
                        if (cell.Title.Text == "C11")
                        {
                            cell.InputValue = EVE.ViscousPyroxeres.ToString();
                            cell.Update();
                        }
                        //Plagioclase 
                        if (cell.Title.Text == "C12")
                        {
                            cell.InputValue = EVE.Plagioclase.ToString();
                            cell.Update();
                        }
                        //Azure Plagioclase
                        if (cell.Title.Text == "C13")
                        {
                            cell.InputValue = EVE.AzurePlagio.ToString();
                            cell.Update();
                        }
                        //Rich Plagioclase
                        if (cell.Title.Text == "C14")
                        {
                            cell.InputValue = EVE.RichPlagio.ToString();
                            cell.Update();
                        }
                        //Omber
                        if (cell.Title.Text == "C15")
                        {
                            cell.InputValue = EVE.Omber.ToString();
                            cell.Update();
                        }
                        //Silvery Omber
                        if (cell.Title.Text == "C16")
                        {
                            cell.InputValue = EVE.SilveryOmber.ToString();
                            cell.Update();
                        }
                        //Golden Omber
                        if (cell.Title.Text == "C17")
                        {
                            cell.InputValue = EVE.GoldenOmber.ToString();
                            cell.Update();
                        }
                        //Kernite
                        if (cell.Title.Text == "C18")
                        {
                            cell.InputValue = EVE.Kernite.ToString();
                            cell.Update();
                        }
                        //Luminous Kernite
                        if (cell.Title.Text == "C19")
                        {
                            cell.InputValue = EVE.LuminKernite.ToString();
                            cell.Update();
                        }
                        //Fiery Kernite
                        if (cell.Title.Text == "C20")
                        {
                            cell.InputValue = EVE.FieryKernite.ToString();
                            cell.Update();
                        }
                        //Jaspet
                        if (cell.Title.Text == "C21")
                        {
                            cell.InputValue = EVE.Jaspet.ToString();
                            cell.Update();
                        }
                        //Pure Jaspet
                        if (cell.Title.Text == "C22")
                        {
                            cell.InputValue = EVE.PureJaspet.ToString();
                            cell.Update();
                        }
                        //Pristine Jaspet
                        if (cell.Title.Text == "C23")
                        {
                            cell.InputValue = EVE.PrisJaspet.ToString();
                            cell.Update();
                        }

                        #endregion

                        #region Cells C24 to C50

                        //Hemorphite
                        if (cell.Title.Text == "C24")
                        {
                            cell.InputValue = EVE.Hemorphite.ToString();
                            cell.Update();
                        }
                        //Vivid Hemorphite
                        if (cell.Title.Text == "C25")
                        {
                            cell.InputValue = EVE.VividHemorphite.ToString();
                            cell.Update();
                        }
                        //Radiant Hemorphite
                        if (cell.Title.Text == "C26")
                        {
                            cell.InputValue = EVE.RadiantHemorphite.ToString();
                            cell.Update();
                        }
                        //Hedbergite
                        if (cell.Title.Text == "C27")
                        {
                            cell.InputValue = EVE.Hedbergite.ToString();
                            cell.Update();
                        }
                        //Vitric Hedbergite
                        if (cell.Title.Text == "C28")
                        {
                            cell.InputValue = EVE.VitricHedbergite.ToString();
                            cell.Update();
                        }
                        //Glazed Hedbergite
                        if (cell.Title.Text == "C29")
                        {
                            cell.InputValue = EVE.GlazedHedbergite.ToString();
                            cell.Update();
                        }
                        //Gneiss
                        if (cell.Title.Text == "C30")
                        {
                            cell.InputValue = EVE.Gneiss.ToString();
                            cell.Update();
                        }
                        //Iridescent Gneiss
                        if (cell.Title.Text == "C31")
                        {
                            cell.InputValue = EVE.IridescentGneiss.ToString();
                            cell.Update();
                        }
                        //Prismatic Gneiss
                        if (cell.Title.Text == "C32")
                        {
                            cell.InputValue = EVE.PrismaticGneiss.ToString();
                            cell.Update();
                        }
                        //Dark Ochre
                        if (cell.Title.Text == "C33")
                        {
                            cell.InputValue = EVE.DarkOchre.ToString();
                            cell.Update();
                        }
                        //Onyx Ochre
                        if (cell.Title.Text == "C34")
                        {
                            cell.InputValue = EVE.OnyxOchre.ToString();
                            cell.Update();
                        }
                        //Obsidian Ochre
                        if (cell.Title.Text == "C35")
                        {
                            cell.InputValue = EVE.ObsidianOchre.ToString();
                            cell.Update();
                        }
                        //Spodumain
                        if (cell.Title.Text == "C36")
                        {
                            cell.InputValue = EVE.Spodumain.ToString();
                            cell.Update();
                        }
                        //Bright Spodumain
                        if (cell.Title.Text == "C37")
                        {
                            cell.InputValue = EVE.BrightSpodumain.ToString();
                            cell.Update();
                        }
                        //Gleaming Spodumain
                        if (cell.Title.Text == "C38")
                        {
                            cell.InputValue = EVE.GleamingSpodumain.ToString();
                            cell.Update();
                        }
                        //Crokite
                        if (cell.Title.Text == "C39")
                        {
                            cell.InputValue = EVE.Crokite.ToString();
                            cell.Update();
                        }
                        //Sharp Crokite
                        if (cell.Title.Text == "C40")
                        {
                            cell.InputValue = EVE.SharpCrokite.ToString();
                            cell.Update();
                        }
                        //Crystalline Crokite
                        if (cell.Title.Text == "C41")
                        {
                            cell.InputValue = EVE.CrystallineCrokite.ToString();
                            cell.Update();
                        }
                        //Bistot
                        if (cell.Title.Text == "C42")
                        {
                            cell.InputValue = EVE.Bistot.ToString();
                            cell.Update();
                        }
                        //Triclinic Bistot
                        if (cell.Title.Text == "C43")
                        {
                            cell.InputValue = EVE.TriclinicBistot.ToString();
                            cell.Update();
                        }
                        //Monoclinic Bistot 
                        if (cell.Title.Text == "C44")
                        {
                            cell.InputValue = EVE.MonoclinicBistot.ToString();
                            cell.Update();
                        }
                        //Arkonor
                        if (cell.Title.Text == "C45")
                        {
                            cell.InputValue = EVE.Arkonor.ToString();
                            cell.Update();
                        }
                        //Crimson Arkonor
                        if (cell.Title.Text == "C46")
                        {
                            cell.InputValue = EVE.CrimsonArkonor.ToString();
                            cell.Update();
                        }
                        //Prime Arkonor
                        if (cell.Title.Text == "C47")
                        {
                            cell.InputValue = EVE.PrimeArkonor.ToString();
                            cell.Update();
                        }
                        //Mercoxit
                        if (cell.Title.Text == "C48")
                        {
                            cell.InputValue = EVE.Mercoxit.ToString();
                            cell.Update();
                        }
                        //Magma Mercoxit
                        if (cell.Title.Text == "C49")
                        {
                            cell.InputValue = EVE.MagmaMercoxit.ToString();
                            cell.Update();
                        }
                        //Vitreous Mercoxit
                        if (cell.Title.Text == "C50")
                        {
                            cell.InputValue = EVE.VitreousMercoxit.ToString();
                            cell.Update();
                        }

                        #endregion
                    }

                    lblNews.Visible = false;
                    lblEditSuccessful.Text = "Export Successful";
                    lblEditSuccessful.Visible = true;
                }
                else
                {
                    lblNews.Visible = false;
                    lblEditSuccessful.Text = "Spreadsheet not found";
                    lblEditSuccessful.Visible = true;
                }
            }
        }

        #region Form Button Handlers

        private void cmdRetrieve_Click(object sender, EventArgs e)
        {
            DisableButtons();
            RetrieveInformation();
            EnableButtons();
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            DisableButtons();
            ExportInformation();
            EnableButtons();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            if (rtbPrices.Text == "")
            {
                MessageBox.Show("No text to clear!");
            }
            else
            {
                rtbPrices.Text = "";
                lblNews.Visible = true;
                lblEditSuccessful.Visible = false;
                cmdExport.Enabled = false;
            }
        }

        private void DisableButtons()
        {
            cmdExport.Enabled = false;
            cmdRetrieve.Enabled = false;
            cmdClear.Enabled = false;
        }

        private void EnableButtons()
        {
            cmdExport.Enabled = true;
            cmdRetrieve.Enabled = true;
            cmdClear.Enabled = true;
        }

        #endregion

        #region Menu Button Handlers

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form About = new FormAbout();
            About.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you wanted options, \nyou should have offered more JCs.", "Give JCs", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void excelPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("And your fat wife.", "WKTT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion
    }
}
