using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Weatherbit {
	internal abstract class API : IDisposable {
		private readonly WebClient m_Web;
		private readonly Uri m_BaseUri;
		private readonly IDictionary<string, string> m_DefaultParameters;

		protected API(Uri baseUri, IDictionary<string, string> defaultParameters) {
			m_DefaultParameters = defaultParameters;
			m_BaseUri = baseUri;

			m_Web = new WebClient();
		}

		protected string Get(string call, IDictionary<string, string> queryParameters) {
			Uri uri = GetUri(call, queryParameters);

			return m_Web.DownloadString(uri);
		}

		protected Task<string> GetAsync(string call, IDictionary<string, string> queryParameters) {
			Uri uri = GetUri(call, queryParameters);

			return m_Web.DownloadStringTaskAsync(uri);
		}

		private Uri GetUri(string call, IDictionary<string, string> queryParameters) {
			var parameters = new Dictionary<string, string>(m_DefaultParameters);
			foreach (KeyValuePair<string, string> item in queryParameters) {
				parameters[item.Key] = item.Value;
			}

			if (parameters.Count > 0) {
				call += "?";
			}

			bool notFirst = false;
			foreach (KeyValuePair<string, string> item in parameters) {
				if (notFirst) {
					call += "&";
					notFirst = true;
				}
				call += Uri.EscapeUriString(item.Key) + "=" + Uri.EscapeUriString(item.Value);
			}

			return new Uri(m_BaseUri, call);
		}

		#region IDisposable Support
		private bool m_DisposedValue = false; // To detect redundant calls

		protected virtual void Dispose(bool disposing) {
			if (!m_DisposedValue) {
				if (disposing) {
					m_Web.Dispose();
				}

				m_DisposedValue = true;
			}
		}

		public void Dispose() {
			Dispose(true);
		}
		#endregion
	}
}
