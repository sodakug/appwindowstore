// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IDataSource.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// Rockmusic_OneMoreNight interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IRockmusic_OneMoreNight
    {
        Task<ObservableCollection<EntitiesBase.YouTubeVideo>> GetData(int pageNumber = 0);
        Task<ObservableCollection<EntitiesBase.YouTubeVideo>> Refresh();
		Task<ObservableCollection<EntitiesBase.YouTubeVideo>> Search(FilterSpecification filter);
    }
}
