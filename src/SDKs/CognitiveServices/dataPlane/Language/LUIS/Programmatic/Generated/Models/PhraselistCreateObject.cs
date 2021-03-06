// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object model for creating a phraselist model.
    /// </summary>
    public partial class PhraselistCreateObject
    {
        /// <summary>
        /// Initializes a new instance of the PhraselistCreateObject class.
        /// </summary>
        public PhraselistCreateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PhraselistCreateObject class.
        /// </summary>
        /// <param name="phrases">List of comma-separated phrases that
        /// represent the Phraselist.</param>
        /// <param name="name">The Phraselist name.</param>
        /// <param name="isExchangeable">An exchangeable phrase list feature
        /// are serves as single feature to the LUIS underlying training
        /// algorithm. It is used as a lexicon lookup feature where its value
        /// is 1 if the lexicon contains a given word or 0 if it doesn’t. Think
        /// of an exchangeable as a synonyms list. A non-exchangeable phrase
        /// list feature has all the phrases in the list serve as separate
        /// features to the underlying training algorithm. So, if you your
        /// phrase list feature contains 5 phrases, they will be mapped to 5
        /// separate features. You can think of the non-exchangeable phrase
        /// list feature as an additional bag of words that you are willing to
        /// add to LUIS existing vocabulary features. Think of a
        /// non-exchangeable as set of different words. Default value is
        /// true.</param>
        public PhraselistCreateObject(string phrases = default(string), string name = default(string), bool? isExchangeable = default(bool?))
        {
            Phrases = phrases;
            Name = name;
            IsExchangeable = isExchangeable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of comma-separated phrases that represent the
        /// Phraselist.
        /// </summary>
        [JsonProperty(PropertyName = "phrases")]
        public string Phrases { get; set; }

        /// <summary>
        /// Gets or sets the Phraselist name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an exchangeable phrase list feature are serves as
        /// single feature to the LUIS underlying training algorithm. It is
        /// used as a lexicon lookup feature where its value is 1 if the
        /// lexicon contains a given word or 0 if it doesn’t. Think of an
        /// exchangeable as a synonyms list. A non-exchangeable phrase list
        /// feature has all the phrases in the list serve as separate features
        /// to the underlying training algorithm. So, if you your phrase list
        /// feature contains 5 phrases, they will be mapped to 5 separate
        /// features. You can think of the non-exchangeable phrase list feature
        /// as an additional bag of words that you are willing to add to LUIS
        /// existing vocabulary features. Think of a non-exchangeable as set of
        /// different words. Default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "isExchangeable")]
        public bool? IsExchangeable { get; set; }

    }
}
