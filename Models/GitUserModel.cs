using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LoraChatBotAPI.Models
{
	public class GitUserModel
	{
		[JsonProperty("avatar_url")]
		public string avatarUrl { get; set; }
	}
}
