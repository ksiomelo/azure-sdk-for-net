// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Magento server dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MagentoObject")]
    public partial class MagentoObjectDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the MagentoObjectDataset class.
        /// </summary>
        public MagentoObjectDataset()
        {
            LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MagentoObjectDataset class.
        /// </summary>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Dataset description.</param>
        /// <param name="structure">Columns that define the structure of the
        /// dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetDataElement.</param>
        /// <param name="parameters">Parameters for dataset.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        /// <param name="folder">The folder that this Dataset is in. If not
        /// specified, Dataset will appear at the root level.</param>
        public MagentoObjectDataset(LinkedServiceReference linkedServiceName, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), object structure = default(object), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), DatasetFolder folder = default(DatasetFolder))
            : base(linkedServiceName, additionalProperties, description, structure, parameters, annotations, folder)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
