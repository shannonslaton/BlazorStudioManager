﻿// these functions are in the global scope for brevity. Implement your own encapsulation.

function createGanttWidget(container, ganttId) {
	if (!ensureKendoAndJquery()) { return; }

	// create the jQuery widgets here
	createGantt($(container).find("#" + ganttId));
}

function destroyWidgets(container) {
	if (!ensureKendoAndJquery()) { return; }

	// dispose the Kendo widgets in the container to avoid memory leaks when Blazor removes their DOM elements
	// if you have your own jQuery events attached, detach them here as well
	kendo.destroy(container);
	// if you have issues with Blazor not clearing all the DOM generated through jQuery, you may need to do it yourself
	// for example, widgets generating popup elements outside of the current container may remain in the DOM and
	// you may need to remove them yourself (e.g., before destroying the Kendo widgets, so you can use the references they offer)
	// $(container).find("#" + ganttId).empty();
}

function createIsLoading(container, id) {
	if (!ensureKendoAndJquery()) { return; }
	$(container).find("#" + id).kendoLoader({
		themeColor: "secondary",
		type: 'pulsing',
		size: 'medium'
	});
}

function ensureKendoAndJquery() {
	if (!window.$ || !window.kendo) {
		alert("something went wrong with loading the Kendo library, review the script references");
		// implement your own preferred error handling and/or CDN fallback
		return false;
	}
	return true;
}

function createWidget(functionName, container, id, dotNetComponent) {
	if (!ensureKendoAndJquery()) { return; }

	// create the jQuery widgets here
	window[functionName]($(container).find("#" + id), dotNetComponent);
}

function createColorPicker($elem, dotNetComponent) {
	$elem.kendoColorPicker({
		value: "#ffffff",
		buttons: false,
		select: function (e) {
			dotNetComponent.invokeMethodAsync("ColorSelected", e.value);
		}
	});
}

function createColorPalette($elem, dotNetComponent) {
	$elem.kendoColorPalette({
		columns: 4,
		tileSize: {
			width: 34,
			height: 19
		},
		palette: [
			"#f0d0c9", "#e2a293", "#d4735e", "#65281a",
			"#eddfda", "#dcc0b6", "#cba092", "#7b4b3a",
			"#fcecd5", "#f9d9ab", "#f6c781", "#c87d0e",
			"#e1dca5", "#d0c974", "#a29a36", "#514d1b",
			"#c6d9f0", "#8db3e2", "#548dd4", "#17365d"
		],
		change: function (e) {
			dotNetComponent.invokeMethodAsync("ColorSelected", e.value);
		}
	});
}

function createGantt($elem) {
	var serviceRoot = "https://demos.telerik.com/kendo-ui/service";
	$elem.kendoGantt({
		dataSource: new kendo.data.GanttDataSource({
			transport: {
				read: {
					url: serviceRoot + "/GanttTasks",
					dataType: "jsonp"
				},
				update: {
					url: serviceRoot + "/GanttTasks/Update",
					dataType: "jsonp"
				},
				destroy: {
					url: serviceRoot + "/GanttTasks/Destroy",
					dataType: "jsonp"
				},
				create: {
					url: serviceRoot + "/GanttTasks/Create",
					dataType: "jsonp"
				},
				parameterMap: function (options, operation) {
					if (operation !== "read") {
						return { models: kendo.stringify(options.models || [options]) };
					}
				}
			},
			schema: {
				model: {
					id: "id",
					fields: {
						id: { from: "ID", type: "number" },
						orderId: { from: "OrderID", type: "number", validation: { required: true } },
						parentId: { from: "ParentID", type: "number", defaultValue: null, validation: { required: true } },
						start: { from: "Start", type: "date" },
						end: { from: "End", type: "date" },
						title: { from: "Title", defaultValue: "", type: "string" },
						percentComplete: { from: "PercentComplete", type: "number" },
						summary: { from: "Summary", type: "boolean" },
						expanded: { from: "Expanded", type: "boolean", defaultValue: true }
					}
				}
			}
		}),
		dependencies: new kendo.data.GanttDependencyDataSource({
			transport: {
				read: {
					url: serviceRoot + "/GanttDependencies",
					dataType: "jsonp"
				},
				update: {
					url: serviceRoot + "/GanttDependencies/Update",
					dataType: "jsonp"
				},
				destroy: {
					url: serviceRoot + "/GanttDependencies/Destroy",
					dataType: "jsonp"
				},
				create: {
					url: serviceRoot + "/GanttDependencies/Create",
					dataType: "jsonp"
				},
				parameterMap: function (options, operation) {
					if (operation !== "read") {
						return { models: kendo.stringify(options.models || [options]) };
					}
				}
			},
			schema: {
				model: {
					id: "id",
					fields: {
						id: { from: "ID", type: "number" },
						predecessorId: { from: "PredecessorID", type: "number" },
						successorId: { from: "SuccessorID", type: "number" },
						type: { from: "Type", type: "number" }
					}
				}
			}
		}),
		views: [
			"day",
			{ type: "week", selected: true },
			"month"
		],
		columns: [
			{ field: "id", title: "ID", width: 60 },
			{ field: "title", title: "Title", editable: true, sortable: true },
			{ field: "start", title: "Start Time", format: "{0:MM/dd/yyyy}", width: 100, editable: true, sortable: true },
			{ field: "end", title: "End Time", format: "{0:MM/dd/yyyy}", width: 100, editable: true, sortable: true }
		],
		height: 700,

		showWorkHours: false,
		showWorkDays: false,

		snap: false
	});
}

function createImageScroll($elem, dotNetComponent) {
	$elem.kendoScrollView({
		enablePager: true,
		contentHeight: "100%"
	});
}

//function createMediaPlayer($elem, dotNetComponent) {
//	$elem.kendoMediaPlayer({
//		autoPlay: true,
//		media: {
//			title: "Our Company Culture - Lesson 1",
//			source: "Video/video1.mp4"
//		}
//	});
//}

function createMediaPlayer(container, id, VideoTitle, VideoUrl, dotNetComponent) {
	if (!ensureKendoAndJquery()) { return; }

	// create the jQuery widgets here

	$(container).find("#" + id).kendoMediaPlayer({
		autoPlay: true,
		media: {
			title: VideoTitle,
			source: VideoUrl
		}
	});
}

function createPdfPreviewer(container, id, FileName, height) {
	if (!ensureKendoAndJquery()) { return; }
	$.when(
		$.getScript("https://cdnjs.cloudflare.com/ajax/libs/pdf.js/2.2.2/pdf.js"),
		$.getScript("https://cdnjs.cloudflare.com/ajax/libs/pdf.js/2.2.2/pdf.worker.js")
	)
	.done(function () {
		window.pdfjsLib.GlobalWorkerOptions.workerSrc = 'https://cdnjs.cloudflare.com/ajax/libs/pdf.js/2.2.2/pdf.worker.js';
	}).then(function () {
		$(container).find("#" + id).kendoPDFViewer({
			pdfjsProcessing: {
				file: FileName
			},
			width: "100%",
			height: height
		});
	})
}

function changePdfViewerPage(id, value) {

	var pdfViewer = $("#" + id).kendoPDFViewer();
	//pdfViewer.width("50%");

	var pdfViewerData = $("#" + id).data("kendoPDFViewer");
	pdfViewerData.activatePage(value);
}

function createImageEditor(container, id, ImageUrl, ImageExtension, userId, isProductionFile) {
	if (!ensureKendoAndJquery()) { return; }
	// create the jQuery widgets here
	$(container).find("#" + id).kendoImageEditor({
		imageUrl: ImageUrl,
		toolbar: {
			items: [
				"crop",
				{
					type: "button",
					text: "Save",
					icon: "save",
					enable: true,
					click: function () {
						var imageEditor = $("#" + id).getKendoImageEditor();
						var currentImage = imageEditor.getCurrentImage().src;
						var formdata = new FormData();
						formdata.append("base64image", currentImage);
						formdata.append("imageName", id);
						formdata.append("fileExtension", ImageExtension);
						formdata.append("userId", userId);
						formdata.append("isProductionFile", isProductionFile);
						formdata.append("FolderName", "images");

						$.ajax({
							url: "/api/Upload/UpdateSaveImage",
							type: "POST",
							data: formdata,
							processData: false,
							contentType: false,
							success: function (result) {
								alert("Updated image has been saved.  It may take a minute to see the update and you may need to refresh the page.")
							}
						});
					}
				}
			]
		}
	});
}

function drawImage(id) {
	var imageEditor = $("#" + id).getKendoImageEditor();
	var currentImage = imageEditor.getCurrentImage().src;
	fetch(currentImage)
		.then((result) => result.blob())
		.then((blob) => getBase64(blob))
		.then((result) => {
			imageEditor.drawImage(result).done(function (image) {
				imageEditor.drawCanvas(image);
				imageEditor._initUndoRedoStack();
				imageEditor._toggleTools();
			}).fail(function (args) {
				alert("Something went wrong!");
			});
		})
};

const getBase64 = (file) => new Promise(function (resolve, reject) {
	let reader = new FileReader();
	reader.readAsDataURL(file);
	reader.onload = () => resolve(reader.result)
	reader.onerror = (error) => reject('Error: ', error);
})
