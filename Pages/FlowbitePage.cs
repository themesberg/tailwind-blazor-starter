using Microsoft.AspNetCore.Components;
using tailwind_4_blazor_starter.Services;

namespace tailwind_4_blazor_starter.Pages;

public abstract class FlowbitePage : ComponentBase
{
    [Inject]
    protected IFlowbiteService FlowbiteService { get; set; } = default!;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await FlowbiteService.InitializeFlowbiteAsync();
        }
        await base.OnAfterRenderAsync(firstRender);
    }
}
