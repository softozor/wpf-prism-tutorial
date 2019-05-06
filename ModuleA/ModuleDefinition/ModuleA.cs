using Interfaces;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
  public class ModuleA : IModule
  {
    readonly IUnityContainer container;
    readonly IRegionManager regionManager;

    public ModuleA(IUnityContainer container, IRegionManager regionManager)
    {
      this.container = container;
      this.regionManager = regionManager;
    }

    public void Initialize()
    {
      RegisterServices();
      RegisterViews();
    }

    void RegisterViews()
    {
      regionManager.RegisterViewWithRegion("ListRegion", typeof(ModuleAViewOne));
      regionManager.RegisterViewWithRegion("ListRegion", typeof(ModuleAViewTwo));
    }

    void RegisterServices()
    {
      container.RegisterType<ITextService, TextService>();
    }
  }
}
