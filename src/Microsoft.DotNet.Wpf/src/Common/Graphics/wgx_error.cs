// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//
//

namespace MS.Internal
{
    #region Enumeration Types

    internal enum WinCodecErrors
    {
        //  Range   0x?8982000 - 0x?8982FFF
        WINCODEC_ERR_GENERIC_ERROR                     = unchecked((int) 0x80004005),
        WINCODEC_ERR_INVALIDPARAMETER                  = unchecked((int) 0x80000003),
        WINCODEC_ERR_OUTOFMEMORY                       = unchecked((int) 0x80000002),
        WINCODEC_ERR_NOTIMPLEMENTED                    = unchecked((int) 0x80000001),
        WINCODEC_ERR_ABORTED                           = unchecked((int) 0x80004004),
        WINCODEC_ERR_ACCESSDENIED                      = unchecked((int) 0x80070005),
        WINCODEC_ERR_VALUEOVERFLOW                     = unchecked((int) 0x80070216),
        WINCODEC_ERR_WRONGSTATE                        = unchecked((int) 0x88982f04),
        WINCODEC_ERR_VALUEOUTOFRANGE                   = unchecked((int) 0x88982f05),
        WINCODEC_ERR_UNKNOWNIMAGEFORMAT                = unchecked((int) 0x88982f07),
        WINCODEC_ERR_UNSUPPORTEDVERSION                = unchecked((int) 0x88982f0B),
        WINCODEC_ERR_NOTINITIALIZED                    = unchecked((int) 0x88982f0C),
        WINCODEC_ERR_ALREADYLOCKED                     = unchecked((int) 0x88982f0D),
        WINCODEC_ERR_PROPERTYNOTFOUND                  = unchecked((int) 0x88982f40),
        WINCODEC_ERR_PROPERTYNOTSUPPORTED              = unchecked((int) 0x88982f41),
        WINCODEC_ERR_PROPERTYSIZE                      = unchecked((int) 0x88982f42),
        WINCODEC_ERR_CODECPRESENT                      = unchecked((int) 0x88982f43),
        WINCODEC_ERR_CODECNOTHUMBNAIL                  = unchecked((int) 0x88982f44),
        WINCODEC_ERR_PALETTEUNAVAILABLE                = unchecked((int) 0x88982f45),
        WINCODEC_ERR_CODECTOOMANYSCANLINES             = unchecked((int) 0x88982f46),
        WINCODEC_ERR_INTERNALERROR                     = unchecked((int) 0x88982f48),
        WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS  = unchecked((int) 0x88982f49),
        WINCODEC_ERR_COMPONENTNOTFOUND                 = unchecked((int) 0x88982f50),
        WINCODEC_ERR_IMAGESIZEOUTOFRANGE               = unchecked((int) 0x88982f51),
        WINCODEC_ERR_TOOMUCHMETADATA                   = unchecked((int) 0x88982f52),
        WINCODEC_ERR_BADIMAGE                          = unchecked((int) 0x88982f60),
        WINCODEC_ERR_BADHEADER                         = unchecked((int) 0x88982f61),
        WINCODEC_ERR_FRAMEMISSING                      = unchecked((int) 0x88982f62),
        WINCODEC_ERR_BADMETADATAHEADER                 = unchecked((int) 0x88982f63),
        WINCODEC_ERR_BADSTREAMDATA                     = unchecked((int) 0x88982f70),
        WINCODEC_ERR_STREAMWRITE                       = unchecked((int) 0x88982f71),
        WINCODEC_ERR_STREAMREAD                        = unchecked((int) 0x88982f72),
        WINCODEC_ERR_STREAMNOTAVAILABLE                = unchecked((int) 0x88982f73),
        WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT            = unchecked((int) 0x88982f80),
        WINCODEC_ERR_UNSUPPORTEDOPERATION              = unchecked((int) 0x88982f81),
        WINCODEC_ERR_INVALIDREGISTRATION               = unchecked((int) 0x88982f8A),
        WINCODEC_ERR_COMPONENTINITIALIZEFAILURE        = unchecked((int) 0x88982f8B),
        WINCODEC_ERR_INSUFFICIENTBUFFER                = unchecked((int) 0x88982f8C),
        WINCODEC_ERR_DUPLICATEMETADATAPRESENT          = unchecked((int) 0x88982f8D),
        WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE            = unchecked((int) 0x88982f8E),
        WINCODEC_ERR_UNEXPECTEDSIZE                    = unchecked((int) 0x88982f8F),
        WINCODEC_ERR_INVALIDQUERYREQUEST               = unchecked((int) 0x88982f90),
        WINCODEC_ERR_UNEXPECTEDMETADATATYPE            = unchecked((int) 0x88982f91),
        WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT    = unchecked((int) 0x88982f92),
        WINCODEC_ERR_INVALIDQUERYCHARACTER             = unchecked((int) 0x88982f93),
    };

    internal enum MILErrors
    {
        //  Range   0x?8980000 - 0x?8980FFF
        WGXHR_CLIPPEDTOEMPTY                            = unchecked((int)  0x8980001),
        WGXHR_EMPTYFILL                                 = unchecked((int)  0x8980002),
        WGXHR_INTERNALTEMPORARYSUCCESS                  = unchecked((int)  0x8980003),
        WGXHR_RESETSHAREDHANDLEMANAGER                  = unchecked((int)  0x8980004),
        WGXERR_GENERIC_ERROR                            = unchecked((int) 0x80004005),
        WGXERR_INVALIDPARAMETER                         = unchecked((int) 0x80000003),
        WGXERR_OUTOFMEMORY                              = unchecked((int) 0x80000002),
        WGXERR_NOTIMPLEMENTED                           = unchecked((int) 0x80000001),
        WGXERR_ABORTED                                  = unchecked((int) 0x80004004),
        WGXERR_ACCESSDENIED                             = unchecked((int) 0x80070005),
        WGXERR_VALUEOVERFLOW                            = unchecked((int) 0x80070216),
        WGXERR_WRONGSTATE                               = WinCodecErrors.WINCODEC_ERR_WRONGSTATE,
        WGXERR_UNSUPPORTEDVERSION                       = WinCodecErrors.WINCODEC_ERR_UNSUPPORTEDVERSION,
        WGXERR_NOTINITIALIZED                           = WinCodecErrors.WINCODEC_ERR_NOTINITIALIZED,
        WGXERR_UNSUPPORTEDPIXELFORMAT                   = WinCodecErrors.WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT,
        WGXERR_UNSUPPORTED_OPERATION                    = WinCodecErrors.WINCODEC_ERR_UNSUPPORTEDOPERATION,
        WGXERR_PALETTEUNAVAILABLE                       = WinCodecErrors.WINCODEC_ERR_PALETTEUNAVAILABLE,
        WGXERR_OBJECTBUSY                               = unchecked((int) 0x88980001),
        WGXERR_INSUFFICIENTBUFFER                       = unchecked((int) 0x88980002),
        WGXERR_WIN32ERROR                               = unchecked((int) 0x88980003),
        WGXERR_SCANNER_FAILED                           = unchecked((int) 0x88980004),
        WGXERR_SCREENACCESSDENIED                       = unchecked((int) 0x88980005),
        WGXERR_DISPLAYSTATEINVALID                      = unchecked((int) 0x88980006),
        WGXERR_NONINVERTIBLEMATRIX                      = unchecked((int) 0x88980007),
        WGXERR_ZEROVECTOR                               = unchecked((int) 0x88980008),
        WGXERR_TERMINATED                               = unchecked((int) 0x88980009),
        WGXERR_BADNUMBER                                = unchecked((int) 0x8898000A),
        WGXERR_INTERNALERROR                            = unchecked((int) 0x88980080),
        WGXERR_DISPLAYFORMATNOTSUPPORTED                = unchecked((int) 0x88980084),
        WGXERR_INVALIDCALL                              = unchecked((int) 0x88980085),
        WGXERR_ALREADYLOCKED                            = unchecked((int) 0x88980086),
        WGXERR_NOTLOCKED                                = unchecked((int) 0x88980087),
        WGXERR_DEVICECANNOTRENDERTEXT                   = unchecked((int) 0x88980088),
        WGXERR_GLYPHBITMAPMISSED                        = unchecked((int) 0x88980089),
        WGXERR_MALFORMEDGLYPHCACHE                      = unchecked((int) 0x8898008A),
        WGXERR_GENERIC_IGNORE                           = unchecked((int) 0x8898008B),
        WGXERR_MALFORMED_GUIDELINE_DATA                 = unchecked((int) 0x8898008C),
        WGXERR_NO_HARDWARE_DEVICE                       = unchecked((int) 0x8898008D),
        WGXERR_NEED_RECREATE_AND_PRESENT                = unchecked((int) 0x8898008E),
        WGXERR_ALREADY_INITIALIZED                      = unchecked((int) 0x8898008F),
        WGXERR_MISMATCHED_SIZE                          = unchecked((int) 0x88980090),
        WGXERR_NO_REDIRECTION_SURFACE_AVAILABLE         = unchecked((int) 0x88980091),
        WGXERR_REMOTING_NOT_SUPPORTED                   = unchecked((int) 0x88980092),
        WGXERR_QUEUED_PRESENT_NOT_SUPPORTED             = unchecked((int) 0x88980093),
        WGXERR_NOT_QUEUING_PRESENTS                     = unchecked((int) 0x88980094),
        WGXERR_NO_REDIRECTION_SURFACE_RETRY_LATER       = unchecked((int) 0x88980095),
        WGXERR_TOOMANYSHADERELEMNTS                     = unchecked((int) 0x88980096),
        // AVAILABLE                                    = unchecked((int) 0x88980097),
        // AVAILABLE                                    = unchecked((int) 0x88980098),
        WGXERR_SHADER_COMPILE_FAILED                    = unchecked((int) 0x88980099),
        WGXERR_MAX_TEXTURE_SIZE_EXCEEDED                = unchecked((int) 0x8898009A),
        // AVAILABLE                                    = unchecked((int) 0x8898009B),
        WGXERR_UCE_INVALIDPACKETHEADER                  = unchecked((int) 0x88980400),
        WGXERR_UCE_UNKNOWNPACKET                        = unchecked((int) 0x88980401),
        WGXERR_UCE_ILLEGALPACKET                        = unchecked((int) 0x88980402),
        WGXERR_UCE_MALFORMEDPACKET                      = unchecked((int) 0x88980403),
        WGXERR_UCE_ILLEGALHANDLE                        = unchecked((int) 0x88980404),
        WGXERR_UCE_HANDLELOOKUPFAILED                   = unchecked((int) 0x88980405),
        WGXERR_UCE_RENDERTHREADFAILURE                  = unchecked((int) 0x88980406),
        WGXERR_UCE_CTXSTACKFRSTTARGETNULL               = unchecked((int) 0x88980407),
        WGXERR_UCE_CONNECTIONIDLOOKUPFAILED             = unchecked((int) 0x88980408),
        WGXERR_UCE_BLOCKSFULL                           = unchecked((int) 0x88980409),
        WGXERR_UCE_MEMORYFAILURE                        = unchecked((int) 0x8898040A),
        WGXERR_UCE_PACKETRECORDOUTOFRANGE               = unchecked((int) 0x8898040B),
        WGXERR_UCE_ILLEGALRECORDTYPE                    = unchecked((int) 0x8898040C),
        WGXERR_UCE_OUTOFHANDLES                         = unchecked((int) 0x8898040D),
        WGXERR_UCE_UNCHANGABLE_UPDATE_ATTEMPTED         = unchecked((int) 0x8898040E),
        WGXERR_UCE_NO_MULTIPLE_WORKER_THREADS           = unchecked((int) 0x8898040F),
        WGXERR_UCE_REMOTINGNOTSUPPORTED                 = unchecked((int) 0x88980410),
        WGXERR_UCE_MISSINGENDCOMMAND                    = unchecked((int) 0x88980411),
        WGXERR_UCE_MISSINGBEGINCOMMAND                  = unchecked((int) 0x88980412),
        WGXERR_UCE_CHANNELSYNCTIMEDOUT                  = unchecked((int) 0x88980413),
        WGXERR_UCE_CHANNELSYNCABANDONED                 = unchecked((int) 0x88980414),
        WGXERR_UCE_UNSUPPORTEDTRANSPORTVERSION          = unchecked((int) 0x88980415),
        WGXERR_UCE_TRANSPORTUNAVAILABLE                 = unchecked((int) 0x88980416),
        WGXERR_UCE_FEEDBACK_UNSUPPORTED                 = unchecked((int) 0x88980417),
        WGXERR_UCE_COMMANDTRANSPORTDENIED               = unchecked((int) 0x88980418),
        WGXERR_UCE_GRAPHICSSTREAMUNAVAILABLE            = unchecked((int) 0x88980419),
        WGXERR_UCE_GRAPHICSSTREAMALREADYOPEN            = unchecked((int) 0x88980420),
        WGXERR_UCE_TRANSPORTDISCONNECTED                = unchecked((int) 0x88980421),
        WGXERR_UCE_TRANSPORTOVERLOADED                  = unchecked((int) 0x88980422),
        WGXERR_UCE_PARTITION_ZOMBIED                    = unchecked((int) 0x88980423),
        WGXERR_UCE_USER_SHADEREFFECT_ERROR              = unchecked((int) 0x88980424),
        WGXERR_AV_NOCLOCK                               = unchecked((int) 0x88980500),
        WGXERR_AV_NOMEDIATYPE                           = unchecked((int) 0x88980501),
        WGXERR_AV_NOVIDEOMIXER                          = unchecked((int) 0x88980502),
        WGXERR_AV_NOVIDEOPRESENTER                      = unchecked((int) 0x88980503),
        WGXERR_AV_NOREADYFRAMES                         = unchecked((int) 0x88980504),
        WGXERR_AV_MODULENOTLOADED                       = unchecked((int) 0x88980505),
        WGXERR_AV_WMPFACTORYNOTREGISTERED               = unchecked((int) 0x88980506),
        WGXERR_AV_INVALIDWMPVERSION                     = unchecked((int) 0x88980507),
        WGXERR_AV_INSUFFICIENTVIDEORESOURCES            = unchecked((int) 0x88980508),
        WGXERR_AV_VIDEOACCELERATIONNOTAVAILABLE         = unchecked((int) 0x88980509),
        WGXERR_AV_REQUESTEDTEXTURETOOBIG                = unchecked((int) 0x8898050A),
        WGXERR_AV_SEEKFAILED                            = unchecked((int) 0x8898050B),
        WGXERR_AV_UNEXPECTEDWMPFAILURE                  = unchecked((int) 0x8898050C),
        WGXERR_AV_MEDIAPLAYERCLOSED                     = unchecked((int) 0x8898050D),
        WGXERR_AV_UNKNOWNHARDWAREERROR                  = unchecked((int) 0x8898050E),
        WGXERR_D3DI_INVALIDSURFACEUSAGE                 = unchecked((int) 0x88980800),
        WGXERR_D3DI_INVALIDSURFACESIZE                  = unchecked((int) 0x88980801),
        WGXERR_D3DI_INVALIDSURFACEPOOL                  = unchecked((int) 0x88980802),
        WGXERR_D3DI_INVALIDSURFACEDEVICE                = unchecked((int) 0x88980803),
        WGXERR_D3DI_INVALIDANTIALIASINGSETTINGS         = unchecked((int) 0x88980804)
    };

    #endregion
}

