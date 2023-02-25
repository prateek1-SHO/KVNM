using KVNM.Models.VillaDto;

namespace KVNM
{
    public static class VillaStore 
    {
        public static List<VillaDto> villaDtos = new List<VillaDto>()
        {
            new VillaDto{Id=1,Name="Hello",squertFee=100,price=500},
            new VillaDto{Id=2,Name="Mai",squertFee=100,price=500},
            new VillaDto{Id=3,Name="{prateek",squertFee=100,price=500}
        };
    }
}
