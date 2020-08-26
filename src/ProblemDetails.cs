﻿namespace Boring
{
    //
    // Summary:
    //     /// A machine-readable format for specifying errors in HTTP API responses based
    //     on https://tools.ietf.org/html/rfc7807. ///
    public class ProblemDetails
    {
        //
        // Summary:
        //     /// A human-readable explanation specific to this occurrence of the problem.
        //     ///
        public string Detail { get; set; }

        //
        // Summary:
        //     /// The HTTP status code([RFC7231], Section 6) generated by the origin server
        //     for this occurrence of the problem. ///
        public int? Status { get; set; }

        //
        // Summary:
        //     /// A short, human-readable summary of the problem type.It SHOULD NOT change
        //     from occurrence to occurrence /// of the problem, except for purposes of localization(e.g.,
        //     using proactive content negotiation; /// see[RFC7231], Section 3.4). ///
        public string Title { get; set; }

        //
        // Summary:
        //     /// A URI reference [RFC3986] that identifies the problem type. This specification
        //     encourages that, when /// dereferenced, it provide human-readable documentation
        //     for the problem type /// (e.g., using HTML [W3C.REC-html5-20141028]). When this
        //     member is not present, its value is assumed to be /// "about:blank". ///
        public string Type { get; set; }
    }
}
