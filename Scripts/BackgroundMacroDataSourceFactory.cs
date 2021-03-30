using DaggerfallConnect.Arena2;
using DaggerfallWorkshop.Utility;

namespace CustomBackgrounds
{
    class BackgroundMacroDataSourceFactory : FallbackMacroDataSourceFactory
    {
        public BackgroundMacroDataSourceFactory(IMacroDataSourceFactory other)
            : base(other)
        {

        }

        public override BiogFile.BiogFileMacroDataSource MakeBiogFileMDS(BiogFile biogFile)
        {
            return new BackgroundBiogFileMacroDataSource(biogFile);
        }
    }
}
