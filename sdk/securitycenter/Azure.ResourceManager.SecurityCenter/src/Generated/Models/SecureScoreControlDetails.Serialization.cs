// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecureScoreControlDetails : IUtf8JsonSerializable, IJsonModel<SecureScoreControlDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecureScoreControlDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecureScoreControlDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecureScoreControlDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecureScoreControlDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(HealthyResourceCount))
            {
                writer.WritePropertyName("healthyResourceCount"u8);
                writer.WriteNumberValue(HealthyResourceCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(UnhealthyResourceCount))
            {
                writer.WritePropertyName("unhealthyResourceCount"u8);
                writer.WriteNumberValue(UnhealthyResourceCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NotApplicableResourceCount))
            {
                writer.WritePropertyName("notApplicableResourceCount"u8);
                writer.WriteNumberValue(NotApplicableResourceCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteNumberValue(Weight.Value);
            }
            if (Optional.IsDefined(Definition))
            {
                writer.WritePropertyName("definition"u8);
                writer.WriteObjectValue(Definition, options);
            }
            writer.WritePropertyName("score"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Max))
            {
                writer.WritePropertyName("max"u8);
                writer.WriteNumberValue(Max.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Current))
            {
                writer.WritePropertyName("current"u8);
                writer.WriteNumberValue(Current.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Percentage))
            {
                writer.WritePropertyName("percentage"u8);
                writer.WriteNumberValue(Percentage.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        SecureScoreControlDetails IJsonModel<SecureScoreControlDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecureScoreControlDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecureScoreControlDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecureScoreControlDetails(document.RootElement, options);
        }

        internal static SecureScoreControlDetails DeserializeSecureScoreControlDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string displayName = default;
            int? healthyResourceCount = default;
            int? unhealthyResourceCount = default;
            int? notApplicableResourceCount = default;
            long? weight = default;
            SecureScoreControlDefinitionItem definition = default;
            int? max = default;
            double? current = default;
            double? percentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = ModelReaderWriter.Read<SystemData>(new BinaryData(Encoding.UTF8.GetBytes(property.Value.GetRawText())), ModelSerializationExtensions.WireOptions, AzureResourceManagerSecurityCenterContext.Default);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("healthyResourceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthyResourceCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("unhealthyResourceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unhealthyResourceCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("notApplicableResourceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notApplicableResourceCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weight"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            weight = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("definition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            definition = SecureScoreControlDefinitionItem.DeserializeSecureScoreControlDefinitionItem(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("score"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("max"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    max = property1.Value.GetInt32();
                                    continue;
                                }
                                if (property1.NameEquals("current"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    current = property1.Value.GetDouble();
                                    continue;
                                }
                                if (property1.NameEquals("percentage"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    percentage = property1.Value.GetDouble();
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecureScoreControlDetails(
                id,
                name,
                type,
                systemData,
                displayName,
                healthyResourceCount,
                unhealthyResourceCount,
                notApplicableResourceCount,
                weight,
                definition,
                max,
                current,
                percentage,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecureScoreControlDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecureScoreControlDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SecureScoreControlDetails)} does not support writing '{options.Format}' format.");
            }
        }

        SecureScoreControlDetails IPersistableModel<SecureScoreControlDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecureScoreControlDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecureScoreControlDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecureScoreControlDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecureScoreControlDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
