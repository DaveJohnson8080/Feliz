namespace Feliz

open Fable.React
open Browser.Types

type attr() =
    static member inline id(value: string) = Interop.mkAttr "id" value
    static member inline id(value: int) = Interop.mkAttr "id" (string value)
    static member inline className(value: string) = Interop.mkAttr "className" value
    static member inline classList (classes: (bool * string) list) =
        classes
        |> List.filter fst
        |> List.map snd
        |> String.concat " "
        |> Interop.mkAttr "className"

    static member inline key(value: string) = Interop.mkAttr "key" value
    static member inline key(value: int) = Interop.mkAttr "key" value
    static member inline defaultChecked(value: bool) = Interop.mkAttr "defaultChecked" value
    static member inline defaultValue(value: string) = Interop.mkAttr "defaultValue" value
    static member inline defaultValue(value: int) = Interop.mkAttr "defaultValue" value
    static member inline defaultValue(value: bool) = Interop.mkAttr "defaultValue" value
    static member inline defaultValue(value: float) = Interop.mkAttr "defaultValue" value
    static member inline value(value: string) = Interop.mkAttr "value" value
    static member inline value(value: int) = Interop.mkAttr "value" value
    static member inline value(value: bool) = Interop.mkAttr "value" value
    static member inline accept(value: string) = Interop.mkAttr "accept" value
    static member inline acceptCharset(value: string) = Interop.mkAttr "acceptCharset" value
    static member inline accessKey(value: string) = Interop.mkAttr "accessKey" value
    static member inline action(value: string) = Interop.mkAttr "action" value
    static member inline alt(value: string) = Interop.mkAttr "alt" value
    static member inline async(value: bool) = Interop.mkAttr "async" value
    static member inline autoComplete(value: string) = Interop.mkAttr "autoComplete" value
    static member inline autoFocus(value: bool) = Interop.mkAttr "autoFocus" value
    static member inline autoPlay(value: bool) = Interop.mkAttr "autoPlay" value
    static member inline capture(value: bool) = Interop.mkAttr "capture" value
    static member inline isChecked(value: bool) = Interop.mkAttr "checked" value
    static member inline cols(value: int) = Interop.mkAttr "cols" value
    static member inline colSpan(value: int) = Interop.mkAttr "colSpan" value
    static member inline contentEditable(value: bool) = Interop.mkAttr "contenteditable" value
    static member inline disabled(value: bool) = Interop.mkAttr "disabled" value
    static member inline height(value: int) = Interop.mkAttr "height" value
    static member inline width(value: int) = Interop.mkAttr "width" value
    static member inline href (value: string) = Interop.mkAttr "href" value
    static member inline hidden (value: bool) = Interop.mkAttr "hidden" value
    static member inline htmlFor(value: string) = Interop.mkAttr "htmlFor" value
    static member inline min(value: int) = Interop.mkAttr "min" value
    static member inline max(value: int) = Interop.mkAttr "max" value
    static member inline maxLength(value: int) = Interop.mkAttr "maxlength" value
    static member inline multiple(value: bool) = Interop.mkAttr "multiple" value
    static member inline method(value: string) = Interop.mkAttr "method" value
    static member inline muted(value: bool) = Interop.mkAttr "muted" value
    static member inline name(value: string) = Interop.mkAttr "name" value
    static member inline placeholder(value: string) = Interop.mkAttr "placeholder" value
    static member inline isOpen(value: bool) = Interop.mkAttr "open" value
    static member inline required(value: bool) = Interop.mkAttr "required" value
    /// Alias for inline `attr.children [ Html.content value ]`
    static member inline content(value: string) = attr.children [ unbox value ]
    /// Alias for inline `attr.children [ Html.content value ]`
    static member inline content(value: int) = attr.children [ unbox value ]
    /// Alias for inline `attr.children [ Html.content value ]`
    static member inline content(value: ReactElement) = attr.children [ value ]
    static member inline rows(value: int) = Interop.mkAttr "rows" value
    static member inline rowSpan(value: int) = Interop.mkAttr "rowSpan" value
    static member inline inputType(value: string) = Interop.mkAttr "type" value
    static member inline src(value: string) = Interop.mkAttr "src" value
    static member inline start(value: string) = Interop.mkAttr "start" value
    static member inline readOnly (value: bool) = Interop.mkAttr "readOnly" value
    static member inline custom(key: string, value: 't) = Interop.mkAttr key value
    static member children (elems: ReactElement list) = Interop.mkAttr "children" (Array.ofList elems)
    static member inline onCut (handler: ClipboardEvent -> unit) = Interop.mkAttr "onCut" handler
    static member inline onPaste (handler: ClipboardEvent -> unit) = Interop.mkAttr "onPaste" handler
    static member inline onCompositionEnd (handler: CompositionEvent -> unit) = Interop.mkAttr "onCompositionEnd" handler
    static member inline onCompositionStart (handler: CompositionEvent -> unit) = Interop.mkAttr "onCompositionStart" handler
    static member inline onCopy (handler: ClipboardEvent -> unit) = Interop.mkAttr "onCopy" handler
    static member inline onCompositionUpdate (handler: CompositionEvent -> unit) = Interop.mkAttr "onCompositionUpdate" handler
    static member inline onFocus (handler: FocusEvent -> unit) = Interop.mkAttr "onFocus" handler
    static member inline onBlur (handler: FocusEvent -> unit) = Interop.mkAttr "onBlur" handler
    static member inline onChange (handler: Event -> unit) = Interop.mkAttr "onChange" handler
    static member inline onInput (handler: Event -> unit) = Interop.mkAttr "onClick" handler
    static member inline onSubmit (handler: Event -> unit) = Interop.mkAttr "onSubmit" handler
    static member inline onReset (handler: Event -> unit) = Interop.mkAttr "onReset" handler
    static member inline onLoad (handler: Event -> unit) = Interop.mkAttr "onLoad" handler
    static member inline onError (handler: Event -> unit) = Interop.mkAttr "onError" handler
    static member inline onKeyDown (handler: KeyboardEvent -> unit) = Interop.mkAttr "onKeyDown" handler
    static member inline onKeyPress (handler: KeyboardEvent -> unit) = Interop.mkAttr "onKeyPress" handler
    static member inline onKeyUp (handler: KeyboardEvent -> unit) = Interop.mkAttr "onKeyUp" handler
    static member inline onAbort (handler: Event -> unit) = Interop.mkAttr "onAbort" handler
    static member inline onCanPlay (handler: Event -> unit) = Interop.mkAttr "onCanPlay" handler
    static member inline onCanPlayThrough (handler: Event -> unit) = Interop.mkAttr "onCanPlayThrough" handler
    static member inline onDurationChange (handler: Event -> unit) = Interop.mkAttr "onDurationChange" handler
    static member inline onEmptied (handler: Event -> unit) = Interop.mkAttr "onEmptied" handler
    static member inline onEncrypted (handler: Event -> unit) = Interop.mkAttr "onEncrypted" handler
    static member inline onEnded (handler: Event -> unit) = Interop.mkAttr "onEnded" handler
    static member inline onLoadedData (handler: Event -> unit) = Interop.mkAttr "onLoadedData" handler
    static member inline onLoadedMetadata (handler: Event -> unit) = Interop.mkAttr "onLoadedMetadata" handler
    static member inline onLoadStart (handler: Event -> unit) = Interop.mkAttr "onLoadStart" handler
    static member inline onPause (handler: Event -> unit) = Interop.mkAttr "onPause" handler
    static member inline onPlay (handler: Event -> unit) = Interop.mkAttr "onPlay" handler
    static member inline onPlaying (handler: Event -> unit) = Interop.mkAttr "onPlaying" handler
    static member inline onProgress (handler: Event -> unit) = Interop.mkAttr "onProgress" handler
    static member inline onRateChange (handler: Event -> unit) = Interop.mkAttr "onRateChange" handler
    static member inline onSeeked (handler: Event -> unit) = Interop.mkAttr "onSeeked" handler
    static member inline onSeeking (handler: Event -> unit) = Interop.mkAttr "onSeeking" handler

    static member inline onStalled (handler: Event -> unit) = Interop.mkAttr "onStalled" handler
    static member inline onSuspend (handler: Event -> unit) = Interop.mkAttr "onSuspend" handler
    static member inline onTimeUpdate (handler: Event -> unit) = Interop.mkAttr "onTimeUpdate" handler
    static member inline onVolumeChange (handler: Event -> unit) = Interop.mkAttr "onVolumeChange" handler
    static member inline onWaiting (handler: Event -> unit) = Interop.mkAttr "onWaiting" handler
    static member inline onClick (handler: MouseEvent -> unit) = Interop.mkAttr "onClick" handler
    static member inline onContextMenu (handler: MouseEvent -> unit) = Interop.mkAttr "onContextMenu" handler
    static member inline onDoubleClick (handler: MouseEvent -> unit) = Interop.mkAttr "onDoubleClick" handler
    static member inline onDrag (handler: DragEvent -> unit) = Interop.mkAttr "onDrag" handler
    static member inline onDragEnd (handler: DragEvent -> unit) = Interop.mkAttr "onDragEnd" handler
    static member inline onDragEnter (handler: DragEvent -> unit) = Interop.mkAttr "onDragEnter" handler
    static member inline onDragExit (handler: DragEvent -> unit) = Interop.mkAttr "onDragExit" handler
    static member inline onDragLeave (handler: DragEvent -> unit) = Interop.mkAttr "onDragLeave" handler
    static member inline onDragOver (handler: DragEvent -> unit) = Interop.mkAttr "onDragOver" handler
    static member inline onDragStart (handler: DragEvent -> unit) = Interop.mkAttr "onDragStart" handler
    static member inline onDrop (handler: DragEvent -> unit) = Interop.mkAttr "onDrop" handler
    static member inline onMouseDown (handler: MouseEvent -> unit) = Interop.mkAttr "onMouseDown"
    static member inline onMouseEnter (handler: MouseEvent -> unit) = Interop.mkAttr "onMouseEnter"
    static member inline onMouseLeave (handler: MouseEvent -> unit) = Interop.mkAttr "onMouseLeave"
    static member inline onMouseMove (handler: MouseEvent -> unit) = Interop.mkAttr "onMouseMove" handler
    static member inline onMouseOut (handler: MouseEvent -> unit) = Interop.mkAttr "onMouseOut" handler
    static member inline onMouseOver (handler: MouseEvent -> unit) = Interop.mkAttr "onMouseOver" handler
    static member inline onSelect (handler: Event -> unit) = Interop.mkAttr "onSelect" handler
    static member inline onTouchCancel (handler: TouchEvent -> unit) = Interop.mkAttr "onTouchCancel" handler
    static member inline onTouchEnd (handler: TouchEvent -> unit) = Interop.mkAttr "onTouchEnd" handler
    static member inline onTouchMove (handler: TouchEvent -> unit) = Interop.mkAttr "onTouchMove" handler
    static member inline onTouchStart (handler: TouchEvent -> unit) = Interop.mkAttr "onTouchStart" handler
    static member inline onScroll (handler: UIEvent -> unit) = Interop.mkAttr "onScroll" handler
    static member inline onWheel (handler: WheelEvent -> unit) = Interop.mkAttr "onWheel" handler
    static member inline onAnimationStart (handler: AnimationEvent -> unit) = Interop.mkAttr "onAnimationStart" handler
    static member inline onAnimationEnd (handler: AnimationEvent -> unit) = Interop.mkAttr "onAnimationEnd" handler
    static member inline onAnimationIteration (handler: AnimationEvent -> unit) = Interop.mkAttr "onAnimationIteration" handler
    static member inline onTransitionEnd (handler: TransitionEvent -> unit) = Interop.mkAttr "onTransitionEnd" handler
    static member inline style (properties: IStyleAttribute list) = Interop.mkAttr "style" (Interop.createObj (unbox properties))
    static member styleList (properties: (bool * IStyleAttribute list) list) =
        properties
        |> List.filter fst
        |> List.collect snd
        |> (unbox >> Interop.createObj)
        |> Interop.mkAttr "style"