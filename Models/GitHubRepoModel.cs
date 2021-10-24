using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoraChatBotAPI.Models
{
	public class GitHubRepoModel
	{
		//JsonProperty will be used for Json Deserialization. It will tell the deserializer wich property to search in the Json

		[JsonProperty("full_name")]		
		public string cardTitle { get; set; }

		[JsonProperty("description")]
		public string cardSubtitle { get; set; }

		[JsonProperty("owner")]
		public GitUserModel owner { get; set; }

		[JsonProperty("created_at")]
		public DateTime creationDate { get; set; }
	}
}
