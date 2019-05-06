using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleB
{
  public class ModuleB : IModule
  {
    readonly IUnityContainer container;
    readonly IRegionManager regionManager;

    public ModuleB(IUnityContainer container, IRegionManager regionManager)
    {
      this.container = container;
      this.regionManager = regionManager;
    }

    public void Initialize()
    {
      RegisterViews();
    }

    void RegisterViews()
    {
      regionManager.RegisterViewWithRegion("MainRegion", typeof(ModuleBViewOne));
    }
  }
}
