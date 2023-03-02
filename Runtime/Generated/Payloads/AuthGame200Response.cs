using System;
using UnityEngine;
using System.Collections.Generic;
using Object = System.Object;

 
namespace MetafabSdk
{
	[Serializable]
	public partial class AuthGame200Response
	{
		public string id;
		public string walletId;
		public string fundingWalletId;
		public string email;
		public string name;
		public Object rpcs;
		public Object redirectUris;
		public string iconImageUrl;
		public string coverImageUrl;
		public string primaryColorHex;
		public string publishedKey;
		public string secretKey;
		public bool? verified;
		public string saltCiphertext;
		public string discordClientId;
		public string updatedAt;
		public string createdAt;
		public string walletDecryptKey;
		public WalletModel wallet;
		public WalletModel fundingWallet;

		/// <summary>
		/// Empty constructor is for use in generics with where: new()
		/// </summary>
		public AuthGame200Response()
		{
		}

		public AuthGame200Response(string id, string walletId, string fundingWalletId, string email, string name, Object rpcs, Object redirectUris, string iconImageUrl, string coverImageUrl, string primaryColorHex, string publishedKey, string secretKey, bool? verified, string saltCiphertext, string discordClientId, string updatedAt, string createdAt, string walletDecryptKey, WalletModel wallet, WalletModel fundingWallet)
		{
			this.id = id;
			this.walletId = walletId;
			this.fundingWalletId = fundingWalletId;
			this.email = email;
			this.name = name;
			this.rpcs = rpcs;
			this.redirectUris = redirectUris;
			this.iconImageUrl = iconImageUrl;
			this.coverImageUrl = coverImageUrl;
			this.primaryColorHex = primaryColorHex;
			this.publishedKey = publishedKey;
			this.secretKey = secretKey;
			this.verified = verified;
			this.saltCiphertext = saltCiphertext;
			this.discordClientId = discordClientId;
			this.updatedAt = updatedAt;
			this.createdAt = createdAt;
			this.walletDecryptKey = walletDecryptKey;
			this.wallet = wallet;
			this.fundingWallet = fundingWallet;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson(this);
		}
	}
}
