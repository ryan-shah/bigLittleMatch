//
//  ViewController.swift
//  BigLittleMatcherXcodeProj
//
//  Created by Steven Penava Jr. on 7/31/17.
//  Copyright © 2017 Steven Penava Jr. All rights reserved.
//

import Cocoa

class Girl: NSObject {
    var name : String = ""
    var prefs : [String] = []
    var numMatches: Int = 0
    var isBig: Bool = false
}

class ViewController: NSViewController {
    
    // Program functions
    
    // Making boxes uneditable
    func disableTextViews() {
        BigsTextView.isEditable = false
        LittlesTextView.isEditable = false
    }
    
    // Disabling buttons unusable at startup
    func disableDependentButtons() {
        EditBigsButtonOutlet.isEnabled = false
        EditLittlesButtonOutlet.isEnabled = false
        ComputeMatchesButtonOutlet.isEnabled = false
        ExportMatchesButtonOutlet.isEnabled = false
    }
    
    func clearLoadedTextViews() {
        BigsTextView.textStorage?.mutableString.setString("")
        LittlesTextView.textStorage?.mutableString.setString("")
    }
        
    func updateLists(bs: inout [Girl], ls: inout [Girl]) {
        clearLoadedTextViews()
        for chick in bs {
            BigsTextView.textStorage?.append(NSAttributedString(string: chick.name))
            BigsTextView.textStorage?.append(NSAttributedString(string: "\n"))
        }
        for chick in ls {
            LittlesTextView.textStorage?.append(NSAttributedString(string: chick.name))
            LittlesTextView.textStorage?.append(NSAttributedString(string: "\n"))
        }
    }
    
    // Opening the CSV file
    func openFile() {
        let fileOpener:NSOpenPanel = NSOpenPanel()
        fileOpener.allowsMultipleSelection = false
        fileOpener.canChooseFiles = true
        fileOpener.canChooseDirectories = false
        fileOpener.allowedFileTypes = ["csv"]
        
        fileOpener.runModal()
        
        if let url = (fileOpener.url) {
            let fileContent = try? String(contentsOf: url)
            let lines : [String] = fileContent!.components(separatedBy: "\n")
            
            var bigs: [Girl] = []
            var littles: [Girl] = []
            
            var headers: String = lines[0]
            
            for line in lines {
                var values = line.components(separatedBy: ",")
                
                if (values.count >= 4) {
                    let currentGirl : Girl = Girl()
                    currentGirl.name = values[2]
                    currentGirl.prefs = []
                    currentGirl.numMatches =  1
                    for var i in (4..<values.count-1) {
                        currentGirl.prefs.append(values[i].lowercased()) // THIS RIGHT?
                    }
                    if (values[3] == "Big") {
                        currentGirl.isBig = true
                        bigs.append(currentGirl)
                    }
                    else if (values[3] == "Little") {
                        currentGirl.isBig = false
                        littles.append(currentGirl)
                    }
                }
            }
            updateLists(bs: &bigs, ls: &littles)
            fileOpener.close()
        }
        else {
            chosenCSV = "null"
        }
    }

    // IBOutlets
    @IBOutlet var BigsTextView: NSTextView!
    @IBOutlet var LittlesTextView: NSTextView!
    @IBOutlet weak var EditBigsButtonOutlet: NSButton!
    @IBOutlet weak var EditLittlesButtonOutlet: NSButton!
    @IBOutlet weak var ComputeMatchesButtonOutlet: NSButton!
    @IBOutlet weak var ExportMatchesButtonOutlet: NSButton!
    @IBOutlet weak var ManualInputButtonOutlet: NSButton!
    var chosenCSV:String = ""
    
    //IBActions
    @IBAction func ExportMatchesButton_Click(_ sender: Any) {
    }
    
    @IBAction func EditBigsButton_Click(_ sender: Any) {
    }
    
    @IBAction func EditLittlesButton_Click(_ sender: Any) {
    }
    
    @IBAction func LoadCSV_Click(_ sender: Any) {
        openFile()
    }
    
    
    @IBAction func ManualInputButton_Click(_ sender: Any) {
    }
    
    

    // Default functions
    override func viewDidLoad() {
        
        super.viewDidLoad()
        
        
        disableTextViews()
        disableDependentButtons()
        
    }

    override var representedObject: Any? {
        didSet {
            
            
        }
    }


}

