using System;
using Microsoft.AspNetCore.Mvc;

namespace SuperHero.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class SuperHeroController: ControllerBase
	{
		[HttpGet]
		public async Task<ActionResult<List<SuperHero>>> GetSuperHeros()
		{
			return new List<SuperHero>
			{
				new SuperHero
				{
					Name = "Varun",
					FirstName = "Varun",
					LastName = "Kumar",
					Place = "Hyd"
				}
			};
		}
	}
}

