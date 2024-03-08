//using System.Reflection.Metadata.Ecma335;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace cavestory;

public class CaveStory : ModSystem {
    
    private ICoreServerAPI serverApi;

    public override void Start(ICoreAPI api) {
        api.Logger.Notification("Hello world from cavestory");
    }

    public override void StartServerSide(ICoreServerAPI api) {
        this.serverApi = api;
    }

    public override bool ShouldLoad(EnumAppSide side) {
        return side == EnumAppSide.Server;
    }
}
