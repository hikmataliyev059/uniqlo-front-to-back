using UniqloFrontToBack.Models.Base;

namespace UniqloFrontToBack.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}