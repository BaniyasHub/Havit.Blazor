﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Havit.Blazor.Documentation.Server.Infrastructure;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class DisableFormValueModelBindingAttribute : Attribute, IResourceFilter
{
	public void OnResourceExecuting(ResourceExecutingContext context)
	{
		var factories = context.ValueProviderFactories;
		factories.RemoveType<FormValueProviderFactory>();
		factories.RemoveType<FormFileValueProviderFactory>();
		factories.RemoveType<JQueryFormValueProviderFactory>();
	}

	public void OnResourceExecuted(ResourceExecutedContext context)
	{
	}
}