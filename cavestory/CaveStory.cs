using Vintagestory.API.Common;

namespace cavestory;

public class CaveStory : ModSystem {
    
    public override void Start(ICoreAPI api) {
        api.Logger.Notification("Hello world from cavestory");
        
    }
}
