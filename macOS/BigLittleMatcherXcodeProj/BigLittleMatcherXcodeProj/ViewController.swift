//
//  ViewController.swift
//  BigLittleMatcherXcodeProj
//
//  Created by Steven Penava Jr. on 7/31/17.
//  Copyright © 2017 Steven Penava Jr. All rights reserved.
//

import Cocoa

class ViewController: NSViewController {
    
    @IBOutlet var BigsTextView: NSTextView!
    @IBOutlet var LittlesTextView: NSTextView!
    @IBOutlet weak var EditBigsButtonOutlet: NSButton!
    @IBOutlet weak var EditLittlesButtonOutlet: NSButton!
    @IBOutlet weak var ComputeMatchesButtonOutlet: NSButton!
    @IBOutlet weak var ExportMatchesButtonOutlet: NSButton!
    
    @IBOutlet weak var ManualInputButtonOutlet: NSButton!
    var chosenCSV:String = ""
    
    
    @IBAction func ExportMatchesButton_Click(_ sender: Any) {
    }
    
    @IBAction func EditBigsButton_Click(_ sender: Any) {
    }
    
    @IBAction func EditLittlesButton_Click(_ sender: Any) {
    }
    
    
    @IBAction func LoadCSV_Click(_ sender: Any) {
        
        let fileOpener:NSOpenPanel = NSOpenPanel()
        fileOpener.allowsMultipleSelection = false
        fileOpener.canChooseFiles = true
        fileOpener.canChooseDirectories = false
        fileOpener.allowedFileTypes = ["csv"]
        
        fileOpener.runModal()
        
        if let url = (fileOpener.url) {
            var chosenCSV = fileOpener.url!.absoluteString
            print(chosenCSV)
        }
        else {
            chosenCSV = "null"
        }
    }
    
    
    @IBAction func ManualInputButton_Click(_ sender: Any) {
    }
    
    
    func disableTextViews() {
        BigsTextView.isEditable = false
        LittlesTextView.isEditable = false
    }
    func disableDependentButtons() {
        EditBigsButtonOutlet.isEnabled = false
        EditLittlesButtonOutlet.isEnabled = false
        ComputeMatchesButtonOutlet.isEnabled = false
        ExportMatchesButtonOutlet.isEnabled = false
    }
    
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

