// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Count
{
    [Obsolete("This class is obsolete. Use CountGetResponse instead.")]
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class CountResponse : global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Count.CountGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Count.CountResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Count.CountResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Count.CountResponse();
        }
    }
}
#pragma warning restore CS0618
