// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


//---------------------------------------------------------------------------

//
// This file is automatically generated.  Please do not edit it directly.
//
// File name: wgx_renderdata_commands.h
//---------------------------------------------------------------------------

#pragma once

struct MILCMD_DRAW_LINE
{
    MILCMD type;
    MilPoint2D point0;
    MilPoint2D point1;
    HMIL_RESOURCE hPen;
    UINT32 QuadWordPad0;
};


struct MILCMD_DRAW_LINE_ANIMATE
{
    MILCMD type;
    MilPoint2D point0;
    MilPoint2D point1;
    HMIL_RESOURCE hPen;
    HMIL_RESOURCE hPoint0Animations;
    HMIL_RESOURCE hPoint1Animations;
    UINT32 QuadWordPad0;
};


struct MILCMD_DRAW_RECTANGLE
{
    MILCMD type;
    MilPointAndSizeD rectangle;
    HMIL_RESOURCE hBrush;
    HMIL_RESOURCE hPen;
};


struct MILCMD_DRAW_RECTANGLE_ANIMATE
{
    MILCMD type;
    MilPointAndSizeD rectangle;
    HMIL_RESOURCE hBrush;
    HMIL_RESOURCE hPen;
    HMIL_RESOURCE hRectangleAnimations;
    UINT32 QuadWordPad0;
};


struct MILCMD_DRAW_ROUNDED_RECTANGLE
{
    MILCMD type;
    MilPointAndSizeD rectangle;
    DOUBLE radiusX;
    DOUBLE radiusY;
    HMIL_RESOURCE hBrush;
    HMIL_RESOURCE hPen;
};


struct MILCMD_DRAW_ROUNDED_RECTANGLE_ANIMATE
{
    MILCMD type;
    MilPointAndSizeD rectangle;
    DOUBLE radiusX;
    DOUBLE radiusY;
    HMIL_RESOURCE hBrush;
    HMIL_RESOURCE hPen;
    HMIL_RESOURCE hRectangleAnimations;
    HMIL_RESOURCE hRadiusXAnimations;
    HMIL_RESOURCE hRadiusYAnimations;
    UINT32 QuadWordPad0;
};


struct MILCMD_DRAW_ELLIPSE
{
    MILCMD type;
    MilPoint2D center;
    DOUBLE radiusX;
    DOUBLE radiusY;
    HMIL_RESOURCE hBrush;
    HMIL_RESOURCE hPen;
};


struct MILCMD_DRAW_ELLIPSE_ANIMATE
{
    MILCMD type;
    MilPoint2D center;
    DOUBLE radiusX;
    DOUBLE radiusY;
    HMIL_RESOURCE hBrush;
    HMIL_RESOURCE hPen;
    HMIL_RESOURCE hCenterAnimations;
    HMIL_RESOURCE hRadiusXAnimations;
    HMIL_RESOURCE hRadiusYAnimations;
    UINT32 QuadWordPad0;
};


struct MILCMD_DRAW_GEOMETRY
{
    MILCMD type;
    HMIL_RESOURCE hBrush;
    HMIL_RESOURCE hPen;
    HMIL_RESOURCE hGeometry;
    UINT32 QuadWordPad0;
};


struct MILCMD_DRAW_IMAGE
{
    MILCMD type;
    MilPointAndSizeD rectangle;
    HMIL_RESOURCE hImageSource;
    UINT32 QuadWordPad0;
};


struct MILCMD_DRAW_IMAGE_ANIMATE
{
    MILCMD type;
    MilPointAndSizeD rectangle;
    HMIL_RESOURCE hImageSource;
    HMIL_RESOURCE hRectangleAnimations;
};


struct MILCMD_DRAW_GLYPH_RUN
{
    MILCMD type;
    HMIL_RESOURCE hForegroundBrush;
    HMIL_RESOURCE hGlyphRun;
};


struct MILCMD_DRAW_DRAWING
{
    MILCMD type;
    HMIL_RESOURCE hDrawing;
    UINT32 QuadWordPad0;
};


struct MILCMD_DRAW_VIDEO
{
    MILCMD type;
    MilPointAndSizeD rectangle;
    HMIL_RESOURCE hPlayer;
    UINT32 QuadWordPad0;
};


struct MILCMD_DRAW_VIDEO_ANIMATE
{
    MILCMD type;
    MilPointAndSizeD rectangle;
    HMIL_RESOURCE hPlayer;
    HMIL_RESOURCE hRectangleAnimations;
};


struct MILCMD_PUSH_CLIP
{
    MILCMD type;
    HMIL_RESOURCE hClipGeometry;
    UINT32 QuadWordPad0;
};


struct MILCMD_PUSH_OPACITY_MASK
{
    MILCMD type;
    MilRectF boundingBoxCacheLocalSpace;
    HMIL_RESOURCE hOpacityMask;
    UINT32 QuadWordPad0;
};


struct MILCMD_PUSH_OPACITY
{
    MILCMD type;
    DOUBLE opacity;
};


struct MILCMD_PUSH_OPACITY_ANIMATE
{
    MILCMD type;
    DOUBLE opacity;
    HMIL_RESOURCE hOpacityAnimations;
    UINT32 QuadWordPad0;
};


struct MILCMD_PUSH_TRANSFORM
{
    MILCMD type;
    HMIL_RESOURCE hTransform;
    UINT32 QuadWordPad0;
};


struct MILCMD_PUSH_GUIDELINE_SET
{
    MILCMD type;
    HMIL_RESOURCE hGuidelines;
    UINT32 QuadWordPad0;
};


struct MILCMD_PUSH_GUIDELINE_Y1
{
    MILCMD type;
    DOUBLE coordinate;
};


struct MILCMD_PUSH_GUIDELINE_Y2
{
    MILCMD type;
    DOUBLE leadingCoordinate;
    DOUBLE offsetToDrivenCoordinate;
};


struct MILCMD_PUSH_EFFECT
{
    MILCMD type;

};


struct MILCMD_POP
{
    MILCMD type;

};

