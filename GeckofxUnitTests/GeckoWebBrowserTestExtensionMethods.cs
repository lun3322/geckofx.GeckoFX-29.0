﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using Gecko;
using System.IO;
using System.Runtime.InteropServices;
using Gecko.DOM;

namespace GeckofxUnitTests
{
	public static class GeckoWebBrowserTextExtensionMethods
	{
		/// <summary>
		/// Helper method to initalize a document with html and wait until document is ready.
		/// </summary>
		/// <param name="innerHtml"></param>
		internal static void TestLoadHtml(this GeckoWebBrowser browser, string innerHtml)
		{
			LoadHtml(browser, innerHtml, false);
		}

		/// <summary>
		/// Helper method to initalize a content editable document with html and wait until document is ready.
		/// </summary>
		/// <param name="innerHtml"></param>
		internal static void TestLoadEditableHtml(this GeckoWebBrowser browser, string innerHtml)
		{
			LoadHtml(browser, innerHtml, true);
		}

		/// <summary>
		/// Helper method to initalize a content editable document with html and wait until document is ready.
		/// </summary>
		/// <param name="innerHtml"></param>
		/// <param name="editable"></param>
		private static void LoadHtml(this GeckoWebBrowser browser, string innerHtml, bool editable)
		{
			string contenteditable = editable ? "contenteditable=\"true\"" : string.Empty;
			browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

							 + "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

							 + "<body " + contenteditable + ">" + innerHtml + "</body></html>");

			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
		}

		/// <summary>
		/// Helper method to initalize a document with html inside a frameset and wait until document is ready.
		/// </summary>
		/// <param name="innerHtml"></param>
		internal static void TestLoadFrameset(this GeckoWebBrowser browser, string innerHtml)
		{
			browser.LoadHtml("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">"

						+ "<html xmlns=\"http://www.w3.org/1999/xhtml\" >"

						+ "<frameset>" + innerHtml + "</frameset></html>");

			browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();
		}
	}
}