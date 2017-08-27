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
    
    @IBAction func LoadCSV_Click(_ sender: Any) {
        
        let fileOpener:NSOpenPanel = NSOpenPanel()
        fileOpener.allowsMultipleSelection = false
        fileOpener.canChooseFiles = true
        fileOpener.canChooseDirectories = false
        fileOpener.allowedFileTypes = ["csv"]
        
        fileOpener.runModal()
        let chosenCSV:String = fileOpener.url!.absoluteString
        
        if (chosenCSV != nil) {
            // file exists
        }
        else {
            // file was not chosen
        }
    }
    
    
    func disableTextViews() {
        BigsTextView.isEditable = false
        LittlesTextView.isEditable = false
    }
    
    override func viewDidLoad() {
        
        super.viewDidLoad()
        
        disableTextViews()
        
    }

    override var representedObject: Any? {
        didSet {
        // Update the view, if already loaded.
        }
    }


}

