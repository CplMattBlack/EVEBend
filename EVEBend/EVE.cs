using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EveAI;
using EveAI.Product;
using EveAI.Live;
using EveAI.Live.Market;

namespace EVEBend
{
    static class EVE
    {
        #region Variables

        static EveAI.Live.Market.EveCentralMarketApi api = new EveAI.Live.Market.EveCentralMarketApi(new EveApi().EveApiCore);
        static EveAI.Map.SolarSystem Jita = api.EveApiCore.FindSolarSystem(30000142);
        static EveAI.Map.Region SinqLaison = api.EveApiCore.FindRegion(10000032);

        //Primary Products
        private static double TritaniumMedian = 0;
        private static double PyeriteMedian = 0;
        private static double MexallonMedian = 0;
        private static double IsogenMedian = 0;
        private static double NocxiumMedian = 0;
        private static double ZydrineMedian = 0;
        private static double MegacyteMedian = 0;
        private static double MorphiteMedian = 0;

        //Secondary Products
        private static double VeldsparMedian = 0;
        private static double ConcVeldsparMedian = 0;
        private static double DenseVeldsparMedian = 0;
        private static double ScorditeMedian = 0;
        private static double CondScorditeMedian = 0;
        private static double MassScorditeMedian = 0;
        private static double PyroxeresMedian = 0;
        private static double SolidPyroxeresMedian = 0;
        private static double ViscousPyroxeresMedian = 0;
        private static double PlagioclaseMedian = 0;
        private static double AzurePlagioMedian = 0;
        private static double RichPlagioMedian = 0;
        private static double OmberMedian = 0;
        private static double SilveryOmberMedian = 0;
        private static double GoldenOmberMedian = 0;
        private static double KerniteMedian = 0;
        private static double LuminKerniteMedian = 0;
        private static double FieryKerniteMedian = 0;
        private static double JaspetMedian = 0;
        private static double PureJaspetMedian = 0;
        private static double PrisJaspetMedian = 0;

        //Tertiary Products
        private static double HemorphiteMedian = 0; 
        private static double VividHemorphiteMedian = 0;
        private static double RadiHemorphiteMedian = 0;
        private static double HedbergiteMedian = 0;
        private static double VitricHedbergiteMedian = 0;
        private static double GlazedHedbergiteMedian = 0;
        private static double GneissMedian = 0;
        private static double IridescentGneissMedian = 0;
        private static double PrismaticGneissMedian = 0;
        private static double DarkOchreMedian = 0;
        private static double OnyxOchreMedian = 0;
        private static double ObsidianOchreMedian = 0;
        private static double SpodumainMedian = 0;
        private static double BrightSpodumainMedian = 0;
        private static double GleamSpodumainMedian = 0;
        private static double CrokiteMedian = 0;
        private static double SharpCrokiteMedian = 0;
        private static double CrysCrokiteMedian = 0;
        private static double BistotMedian = 0;
        private static double TriBistotMedian = 0;
        private static double MonoBistotMedian = 0;
        private static double ArkonorMedian = 0;
        private static double CrimArkonorMedian = 0;
        private static double PrimeArkonorMedian = 0;
        private static double MercoxitMedian = 0;
        private static double MagmaMercoxitMedian = 0;
        private static double VitrMercoxitMedian = 0;

        #endregion

        #region Properties

        #region Primary Properties

        public static double Tritanium
        {
            get { return TritaniumMedian; }
        }
        public static double Pyerite
        {
            get { return PyeriteMedian; }
        }
        public static double Mexallon
        {
            get { return MexallonMedian; }
        }
        public static double Isogen
        {
            get { return IsogenMedian; }
        }
        public static double Nocxium
        {
            get { return NocxiumMedian; }
        }
        public static double Zydrine
        {
            get { return ZydrineMedian; }
        }
        public static double Megacyte
        {
            get { return MegacyteMedian; }
        }
        public static double Morphite
        {
            get { return MorphiteMedian; }
        }

        #endregion

        #region Secondary Properties

        public static double Veldspar
        {
            get { return VeldsparMedian; }
        }
        public static double ConcVeldspar
        {
            get { return ConcVeldsparMedian; }
        }
        public static double DenseVeldspar
        {
            get { return DenseVeldsparMedian; }
        }
        public static double Scordite
        {
            get { return ScorditeMedian; }
        }
        public static double CondScordite
        {
            get { return CondScorditeMedian; }
        }
        public static double MassScordite
        {
            get { return MassScorditeMedian; }
        }
        public static double Pyroxeres
        {
            get { return PyroxeresMedian; }
        }
        public static double SolidPyroxeres
        {
            get { return SolidPyroxeresMedian; }
        }
        public static double ViscousPyroxeres
        {
            get { return ViscousPyroxeresMedian; }
        }
        public static double Plagioclase
        {
            get { return PlagioclaseMedian; }
        }
        public static double AzurePlagio
        {
            get { return AzurePlagioMedian; }
        }
        public static double RichPlagio
        {
            get { return RichPlagioMedian; }
        }
        public static double Omber
        {
            get { return OmberMedian; }
        }
        public static double SilveryOmber
        {
            get { return SilveryOmberMedian; }
        }
        public static double GoldenOmber
        {
            get { return GoldenOmberMedian; }
        }
        public static double Kernite
        {
            get { return KerniteMedian; }
        }
        public static double LuminKernite
        {
            get { return LuminKerniteMedian; }
        }
        public static double FieryKernite
        {
            get { return FieryKerniteMedian; }
        }
        public static double Jaspet
        {
            get { return JaspetMedian; }
        }
        public static double PureJaspet
        {
            get { return PureJaspetMedian; }
        }
        public static double PrisJaspet
        {
            get { return PrisJaspetMedian; }
        }

        #endregion

        #region Tertiary Properties

        public static double Hemorphite
        {
            get { return HemorphiteMedian; }
        }
        public static double VividHemorphite
        {
            get { return VividHemorphiteMedian; }
        }
        public static double RadiantHemorphite
        {
            get { return RadiHemorphiteMedian; }
        }
        public static double Hedbergite
        {
            get { return HedbergiteMedian; }
        }
        public static double VitricHedbergite
        {
            get { return VitricHedbergiteMedian; }
        }
        public static double GlazedHedbergite
        {
            get { return GlazedHedbergiteMedian; }
        }
        public static double Gneiss
        {
            get { return GneissMedian; }
        }
        public static double IridescentGneiss
        {
            get { return IridescentGneissMedian; }
        }
        public static double PrismaticGneiss
        {
            get { return PrismaticGneissMedian; }
        }
        public static double DarkOchre
        {
            get { return DarkOchreMedian; }
        }
        public static double OnyxOchre
        {
            get { return OnyxOchreMedian; }
        }
        public static double ObsidianOchre
        {
            get { return ObsidianOchreMedian; }
        }
        public static double Spodumain
        {
            get { return SpodumainMedian; }
        }
        public static double BrightSpodumain
        {
            get { return BrightSpodumainMedian; }
        }
        public static double GleamingSpodumain
        {
            get { return GleamSpodumainMedian; }
        }
        public static double Crokite
        {
            get { return CrokiteMedian; }
        }
        public static double SharpCrokite
        {
            get { return SharpCrokiteMedian; }
        }
        public static double CrystallineCrokite
        {
            get { return CrysCrokiteMedian; }
        }
        public static double Bistot
        {
            get { return BistotMedian; }
        }
        public static double TriclinicBistot
        {
            get { return TriBistotMedian; }
        }
        public static double MonoclinicBistot 
        {
            get { return MonoBistotMedian; }
        }
        public static double Arkonor
        {
            get { return ArkonorMedian; }
        }
        public static double CrimsonArkonor
        {
            get { return CrimArkonorMedian; }
        }
        public static double PrimeArkonor
        {
            get { return PrimeArkonorMedian; }
        }
        public static double Mercoxit
        {
            get { return MercoxitMedian; }
        }
        public static double MagmaMercoxit
        {
            get { return MagmaMercoxitMedian; }
        }
        public static double VitreousMercoxit
        {
            get { return VitrMercoxitMedian; }
        }

        #endregion

        #endregion

        public static List<EveAI.Product.ProductType> RetrievePrimaryProducts()
        {
            List<EveAI.Product.ProductType> lstPrimaryProducts = new List<EveAI.Product.ProductType>();

            //Cells G2 to N2
            EveAI.Product.ProductType productTritanium = api.EveApiCore.FindProductType(34); //Tritanium
            EveAI.Product.ProductType productPeryite = api.EveApiCore.FindProductType(35); //Pyerite
            EveAI.Product.ProductType productMexallon = api.EveApiCore.FindProductType(36); //Mexallon
            EveAI.Product.ProductType productIsogen = api.EveApiCore.FindProductType(37); //Isogen
            EveAI.Product.ProductType productNocxium = api.EveApiCore.FindProductType(38); //Nocxium
            EveAI.Product.ProductType productZydrine = api.EveApiCore.FindProductType(39); //Zydrine
            EveAI.Product.ProductType productMegacyte = api.EveApiCore.FindProductType(40); //Megacyte
            EveAI.Product.ProductType productMorphite = api.EveApiCore.FindProductType(11399); //Megacyte

            lstPrimaryProducts.Add(productTritanium);
            lstPrimaryProducts.Add(productPeryite);
            lstPrimaryProducts.Add(productMexallon);
            lstPrimaryProducts.Add(productIsogen);
            lstPrimaryProducts.Add(productNocxium);
            lstPrimaryProducts.Add(productZydrine);
            lstPrimaryProducts.Add(productMegacyte);
            lstPrimaryProducts.Add(productMorphite);

            return lstPrimaryProducts;
        }

        public static List<EveAI.Product.ProductType> RetrieveSecondaryProducts()
        {
            List<EveAI.Product.ProductType> lstSecondaryProducts = new List<EveAI.Product.ProductType>();

            //Cells C3 to C23
            EveAI.Product.ProductType productVeldspar = api.EveApiCore.FindProductType(1230); //Veldspar
            EveAI.Product.ProductType productConcVeldspar = api.EveApiCore.FindProductType(17470); //Concentrated Veldspar
            EveAI.Product.ProductType productDenseVeldspar = api.EveApiCore.FindProductType(17471); //Dense Veldspar
            EveAI.Product.ProductType productScordite = api.EveApiCore.FindProductType(1228); //Scordite
            EveAI.Product.ProductType productCondScordite = api.EveApiCore.FindProductType(17463); //Condensed Scordite
            EveAI.Product.ProductType productMassScordite = api.EveApiCore.FindProductType(17464); //Massive Scordite
            EveAI.Product.ProductType productPyroxeres = api.EveApiCore.FindProductType(1224); //Pyroxeres
            EveAI.Product.ProductType productSolidPyroxeres = api.EveApiCore.FindProductType(17459); //Solid Pyroxeres 
            EveAI.Product.ProductType productViscousPyroxeres = api.EveApiCore.FindProductType(17460); //Viscous Pyroxeres
            EveAI.Product.ProductType productPlagioclase = api.EveApiCore.FindProductType(18); //Plagioclase 
            EveAI.Product.ProductType productAzurePlagio = api.EveApiCore.FindProductType(17455); //Azure Plagioclase
            EveAI.Product.ProductType productRichPlagio = api.EveApiCore.FindProductType(17456); //Rich Plagioclase
            EveAI.Product.ProductType productOmber = api.EveApiCore.FindProductType(1227); //Omber
            EveAI.Product.ProductType productSilveryOmber = api.EveApiCore.FindProductType(17867); //Silvery Omber
            EveAI.Product.ProductType productGoldenOmber = api.EveApiCore.FindProductType(17868); //Golden Omber
            EveAI.Product.ProductType productKernite = api.EveApiCore.FindProductType(20); //Kernite
            EveAI.Product.ProductType productLuminKernite = api.EveApiCore.FindProductType(17452); //Luminous Kernite
            EveAI.Product.ProductType productFieryKernite = api.EveApiCore.FindProductType(17453); //Fiery Kernite
            EveAI.Product.ProductType productJaspet = api.EveApiCore.FindProductType(1226); //Jaspet
            EveAI.Product.ProductType productPureJaspet = api.EveApiCore.FindProductType(17448); //Pure Jaspet
            EveAI.Product.ProductType productPrisJaspet = api.EveApiCore.FindProductType(17449); //Pristine Jaspet

            lstSecondaryProducts.Add(productVeldspar);
            lstSecondaryProducts.Add(productConcVeldspar);
            lstSecondaryProducts.Add(productDenseVeldspar);
            lstSecondaryProducts.Add(productScordite);
            lstSecondaryProducts.Add(productCondScordite);
            lstSecondaryProducts.Add(productMassScordite);
            lstSecondaryProducts.Add(productPyroxeres);
            lstSecondaryProducts.Add(productSolidPyroxeres);
            lstSecondaryProducts.Add(productViscousPyroxeres);
            lstSecondaryProducts.Add(productPlagioclase);
            lstSecondaryProducts.Add(productAzurePlagio);
            lstSecondaryProducts.Add(productRichPlagio);
            lstSecondaryProducts.Add(productOmber);
            lstSecondaryProducts.Add(productSilveryOmber);
            lstSecondaryProducts.Add(productGoldenOmber);
            lstSecondaryProducts.Add(productKernite);
            lstSecondaryProducts.Add(productLuminKernite);
            lstSecondaryProducts.Add(productFieryKernite);
            lstSecondaryProducts.Add(productJaspet);
            lstSecondaryProducts.Add(productPureJaspet);
            lstSecondaryProducts.Add(productPrisJaspet);

            return lstSecondaryProducts;
        }

        public static List<EveAI.Product.ProductType> RetrieveTertiaryProducts()
        {
            List<EveAI.Product.ProductType> lstTertiaryProducts = new List<EveAI.Product.ProductType>();

            EveAI.Product.ProductType productHemorphite = api.EveApiCore.FindProductType(1231); //Hemorphite
            EveAI.Product.ProductType productVividHemorphite = api.EveApiCore.FindProductType(17444); //Vivid Hemorphite
            EveAI.Product.ProductType productRadiHemorphite = api.EveApiCore.FindProductType(17445); //Radiant Hemorphite
            EveAI.Product.ProductType productHedbergite = api.EveApiCore.FindProductType(21); //Hedbergite
            EveAI.Product.ProductType productVitricHedbergite = api.EveApiCore.FindProductType(17440); //Vitric Hedbergite
            EveAI.Product.ProductType productGlazedHedbergite = api.EveApiCore.FindProductType(17441); //Glazed Hedbergite
            EveAI.Product.ProductType productGneiss = api.EveApiCore.FindProductType(1229); //Gneiss
            EveAI.Product.ProductType productIridescentGneiss = api.EveApiCore.FindProductType(17865); //Iridescent Gneiss
            EveAI.Product.ProductType productPrismaticGneiss = api.EveApiCore.FindProductType(17866); //Prismatic Gneiss
            EveAI.Product.ProductType productDarkOchre = api.EveApiCore.FindProductType(1232); //Dark Ochre
            EveAI.Product.ProductType productOnyxOchre = api.EveApiCore.FindProductType(17436); //Onyx Ochre
            EveAI.Product.ProductType productObsidianOchre = api.EveApiCore.FindProductType(17437); //Obsidian Ochre
            EveAI.Product.ProductType productSpodumain = api.EveApiCore.FindProductType(19); //Spodumain
            EveAI.Product.ProductType productBrightSpodumain = api.EveApiCore.FindProductType(17466); //Bright Spodumain
            EveAI.Product.ProductType productGleamSpodumain = api.EveApiCore.FindProductType(17467); //Gleaming Spodumain
            EveAI.Product.ProductType productCrokite = api.EveApiCore.FindProductType(1225); //Crokite
            EveAI.Product.ProductType productSharpCrokite = api.EveApiCore.FindProductType(17432); //Sharp Crokite
            EveAI.Product.ProductType productCrysCrokite = api.EveApiCore.FindProductType(17433); //Crystalline Crokite
            EveAI.Product.ProductType productBistot = api.EveApiCore.FindProductType(1223); //Bistot
            EveAI.Product.ProductType productTriBistot = api.EveApiCore.FindProductType(17428); //Triclinic Bistot
            EveAI.Product.ProductType productMonoBistot = api.EveApiCore.FindProductType(17429); //Monoclinic Bistot 
            EveAI.Product.ProductType productArkonor = api.EveApiCore.FindProductType(22); //Arkonor
            EveAI.Product.ProductType productCrimArkonor = api.EveApiCore.FindProductType(17425); //Crimson Arkonor
            EveAI.Product.ProductType productPrimeArkonor = api.EveApiCore.FindProductType(17426); //Prime Arkonor
            EveAI.Product.ProductType productMercoxit = api.EveApiCore.FindProductType(11396); //Mercoxit
            EveAI.Product.ProductType productMagmaMercoxit = api.EveApiCore.FindProductType(17869); //Magma Mercoxit
            EveAI.Product.ProductType productVitrMercoxit = api.EveApiCore.FindProductType(17870); //Vitreous Mercoxit

            lstTertiaryProducts.Add(productHemorphite);
            lstTertiaryProducts.Add(productVividHemorphite);
            lstTertiaryProducts.Add(productRadiHemorphite);
            lstTertiaryProducts.Add(productHedbergite);
            lstTertiaryProducts.Add(productVitricHedbergite);
            lstTertiaryProducts.Add(productGlazedHedbergite);
            lstTertiaryProducts.Add(productGneiss);
            lstTertiaryProducts.Add(productIridescentGneiss);
            lstTertiaryProducts.Add(productPrismaticGneiss);
            lstTertiaryProducts.Add(productDarkOchre);
            lstTertiaryProducts.Add(productOnyxOchre);
            lstTertiaryProducts.Add(productObsidianOchre);
            lstTertiaryProducts.Add(productSpodumain);
            lstTertiaryProducts.Add(productBrightSpodumain);
            lstTertiaryProducts.Add(productGleamSpodumain);
            lstTertiaryProducts.Add(productCrokite);
            lstTertiaryProducts.Add(productSharpCrokite);
            lstTertiaryProducts.Add(productCrysCrokite);
            lstTertiaryProducts.Add(productBistot);
            lstTertiaryProducts.Add(productTriBistot);
            lstTertiaryProducts.Add(productMonoBistot);
            lstTertiaryProducts.Add(productArkonor);
            lstTertiaryProducts.Add(productCrimArkonor);
            lstTertiaryProducts.Add(productPrimeArkonor);
            lstTertiaryProducts.Add(productMercoxit);
            lstTertiaryProducts.Add(productMagmaMercoxit);
            lstTertiaryProducts.Add(productVitrMercoxit);

            return lstTertiaryProducts;
        }

        public static EveAI.Live.Market.ProductStatistics GetProductInformation(EveAI.Product.ProductType product)
        {
            EveAI.Live.Market.ProductStatistics Stats = api.GetProductStatistics(product, SinqLaison);

            //Primary Products
            if (product.Name == "Tritanium")
            {
                TritaniumMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Pyerite")
            {
                PyeriteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Mexallon")
            {
                MexallonMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Isogen")
            {
                IsogenMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Nocxium")
            {
                NocxiumMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Zydrine")
            {
                ZydrineMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Megacyte")
            {
                MegacyteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Morphite")
            {
                MorphiteMedian = Stats.SellOrders.Median;
            }
            //Secondary Products
            else if (product.Name == "Veldspar")
            {
                VeldsparMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Concentrated Veldspar")
            {
                ConcVeldsparMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Dense Veldspar")
            {
                DenseVeldsparMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Scordite")
            {
                ScorditeMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Condensed Scordite")
            {
                CondScorditeMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Massive Scordite")
            {
                MassScorditeMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Pyroxeres")
            {
                PyroxeresMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Solid Pyroxeres")
            {
                SolidPyroxeresMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Viscous Pyroxeres")
            {
                ViscousPyroxeresMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Plagioclase")
            {
                PlagioclaseMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Azure Plagioclase")
            {
                AzurePlagioMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Rich Plagioclase")
            {
                RichPlagioMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Omber")
            {
                OmberMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Silvery Omber")
            {
                SilveryOmberMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Golden Omber")
            {
                GoldenOmberMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Kernite")
            {
                KerniteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Luminous Kernite")
            {
                LuminKerniteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Fiery Kernite")
            {
                FieryKerniteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Jaspet")
            {
                JaspetMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Pure Jaspet")
            {
                PureJaspetMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Pristine Jaspet")
            {
                PrisJaspetMedian = Stats.SellOrders.Median;
            }
            //Tertiary Products
            else if (product.Name == "Hemorphite")
            {
                HemorphiteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Vivid Hemorphite")
            {
                VividHemorphiteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Radiant Hemorphite")
            {
                RadiHemorphiteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Hedbergite")
            {
                HedbergiteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Vitric Hedbergite")
            {
                VitricHedbergiteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Glazed Hedbergite")
            {
                GlazedHedbergiteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Gneiss")
            {
                GneissMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Iridescent Gneiss")
            {
                IridescentGneissMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Prismatic Gneiss")
            {
                PrismaticGneissMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Dark Ochre")
            {
                DarkOchreMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Onyx Ochre")
            {
                OnyxOchreMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Obsidian Ochre")
            {
                ObsidianOchreMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Spodumain")
            {
                SpodumainMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Bright Spodumain")
            {
                BrightSpodumainMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Gleaming Spodumain")
            {
                GleamSpodumainMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Crokite")
            {
                CrokiteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Sharp Crokite")
            {
                SharpCrokiteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Crystalline Crokite")
            {
                CrysCrokiteMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Bistot")
            {
                BistotMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Triclinic Bistot")
            {
                TriBistotMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Monoclinic Bistot")
            {
                MonoBistotMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Arkonor")
            {
                ArkonorMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Crimson Arkonor")
            {
                CrimArkonorMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Prime Arkonor")
            {
                PrimeArkonorMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Mercoxit")
            {
                MercoxitMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Magma Mercoxit")
            {
                MagmaMercoxitMedian = Stats.SellOrders.Median;
            }
            else if (product.Name == "Vitreous Mercoxit")
            {
                VitrMercoxitMedian = Stats.SellOrders.Median;
            }            

            return Stats;
        }
    }
}
