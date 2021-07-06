﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using VerzorgingApp.Client.Services;
using VerzorgingApp.Shared;

namespace VerzorgingApp.Client.Pages.Caretakers
{
    public class CaretakerIndexBase : ComponentBase
    {
        [Inject]
        public ICaretakerDataService CaretakerDataService { get; set; }
        public List<Caretaker> Caretakers { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Caretakers = (await CaretakerDataService.GetAllCaretakers()).ToList();

        }
    }
}
