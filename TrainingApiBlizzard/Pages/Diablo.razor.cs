using DataLayer.Service;
using Microsoft.AspNetCore.Components;

namespace TrainingApiBlizzard.Pages
{
    public partial class Diablo : ComponentBase
    {
        [Inject]
        public DiabloService DiabloService { get; set; }

        public async Task GetAct()
        {
            var test2 = await DiabloService.GetActAsync();
            var test = 0;
        }

    }
}
