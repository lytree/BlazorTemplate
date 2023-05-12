import { defineConfig, presetUno } from 'unocss'

export default defineConfig({
    presets: [
        presetUno(),
    ],
    cli: {
        entry: {}, // CliEntryItem | CliEntryItem[]
    },
    extraContent: {
        filesystem: ['./**/*.razor'],
    }
})