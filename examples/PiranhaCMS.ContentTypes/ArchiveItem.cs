using PiranhaCMS.ContentTypes.Pages;
using Piranha;
using Piranha.Extend.Fields;
using Piranha.Models;

public class ArchiveItem
{
    // The id of the page
    public Guid Id { get; set; }

    // The model
    public PageInfo Model { get; set; }

    // Gets a single item with the provided id using the
    // injected services you specify.
    static async Task<ArchiveItem> GetById(string id, IApi api)
    {
        return new ArchiveItem
        {
            Id = new Guid(id),
            Model = await api.Pages.GetByIdAsync<PageInfo>(new Guid(id))
        };
    }

    // Gets all of the available items to choose from using
    // the injected services you specify.
    static async Task<IEnumerable<DataSelectFieldItem>> GetList(IApi api)
    {
        var archives = await api.Pages.GetAllAsync<MaquinasArchive>();

        return archives.Select(p => new DataSelectFieldItem
        {
            Id = p.Id.ToString(),
            Name = p.Title
        });
    }
}