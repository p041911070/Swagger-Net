﻿using System;
using System.Net;

namespace Swagger.Net.Swagger.Annotations
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class SwaggerResponseAttribute : Attribute
    {
        public SwaggerResponseAttribute(HttpStatusCode statusCode)
        {
            StatusCode = (int)statusCode;
        }

        public SwaggerResponseAttribute(HttpStatusCode statusCode, string description = null, Type type = null, string typeName = null )
            : this(statusCode)
        {
            Description = description;
            Type = type;
            TypeName = typeName;
        }

        public SwaggerResponseAttribute(int statusCode)
        {
            StatusCode = statusCode;
        }

        public SwaggerResponseAttribute(int statusCode, string description = null, Type type = null, string typeName = null)
            : this(statusCode)
        {
            Description = description;
            Type = type;
            TypeName = typeName;
        }

        public int StatusCode { get; private set; }

        public string Description { get; set; }

        public Type Type { get; set; }

        public string TypeName { get; set; }
    }
}