using Microsoft.JSInterop;
using BlazorStudioManager.Shared.HelperModels;
using System.Threading.Tasks;

namespace BlazorStudioManager.Client.Interop
{
    public static class VideoJS
    {
        public static ValueTask<MediaDevice[]> GetVideoDevicesAsync(
              this IJSRuntime jsRuntime) =>
              jsRuntime?.InvokeAsync<MediaDevice[]>(
                  "videoInterop.getVideoDevices") ?? new ValueTask<MediaDevice[]>();

        public static ValueTask StartVideoAsync(
            this IJSRuntime jSRuntime,
            string deviceId,
            string selector) =>
            jSRuntime?.InvokeVoidAsync(
                "videoInterop.startVideo",
                deviceId, selector) ?? new ValueTask();

        public static ValueTask<bool> CreateOrJoinRoomAsync(
            this IJSRuntime jsRuntime,
            string roomName,
            string token) =>
            jsRuntime?.InvokeAsync<bool>(
                "videoInterop.createOrJoinRoom",
                roomName, token) ?? new ValueTask<bool>(false);

        public static ValueTask LeaveRoomAsync(
            this IJSRuntime jsRuntime) =>
            jsRuntime?.InvokeVoidAsync(
                "videoInterop.leaveRoom") ?? new ValueTask();
    }
}
