using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]

public class ParentsController(IParentService parentService)
{
        [HttpGet("Gets-Parents")]
    public async Task<List<Parents>> GetParents()
    {
        return await parentService.GetParents();
    }

    [HttpPost("Add-Parent")]

    public async Task AddParent(Parents parent)
    {
        await parentService.AddParent(parent);
    }

    [HttpDelete("Delete-Parent")]

    public async Task DeleteParent(int parentId)
    {
        await parentService.DeleteParent(parentId);
    }

    [HttpPut("Update-Parent")]

    public async Task UpdateParent(Parents parent)
    {
        await parentService.UpdateParent(parent);
    }
}
