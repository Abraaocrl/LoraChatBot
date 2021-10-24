using LoraChatBotAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoraChatBotAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GitHubController : ControllerBase
	{
		private string urlApiGithub = "https://api.github.com";

		[HttpGet("{user}")]
		public async Task<IActionResult> List5OldestRepos(string user)
		{
			try
			{
				WebRequest request = WebRequest.Create($"{urlApiGithub}/users/{user}/repos");

				//All requests to the GitHub API must include the User-Agent header, otherwise it will return a 403 Forbiden response
				request.Headers.Add("User-Agent", "request");

				//Sending the request and reading it's json response into a string that will be later deserialized
				Stream responseStream =(await request.GetResponseAsync()).GetResponseStream();
				StreamReader strReader = new StreamReader(responseStream);
				string response = await strReader.ReadToEndAsync();


				List<GitHubRepoModel> repos = JsonConvert.DeserializeObject<List<GitHubRepoModel>>(response);				
				List<GitHubRepoModel> oldestRepos = repos.OrderBy(x => x.creationDate).Take(5).ToList();
				return Ok(oldestRepos);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
