﻿using Swagger.Net.Swagger;
using System.Web.Http.Description;

namespace Swagger.Net.Dummy.SwaggerExtensions
{
    public class AddFileUploadParams : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.operationId == "FileUpload_PostFormData")
            {
                operation.consumes.Add("application/form-data");
                operation.parameters = new[]
                {
                    new Parameter
                    {
                        name = "file",
                        @in = "formData",
                        required = true,
                        type = "file"
                    }
                };
            }
        }
    }
}
